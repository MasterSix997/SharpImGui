FROM alpine AS sources
WORKDIR /cimgui
RUN apk update && apk add --no-cache git build-base
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimgui.git .
RUN git submodule update --init --recursive

FROM alpine AS generator
WORKDIR /cimgui
COPY --from=sources /cimgui ./
RUN apk add --no-cache luajit lua5.1-dev gcc musl-dev
WORKDIR /cimgui/generator
RUN luajit generator.lua gcc "internal noimstrv comments constructors" glfw opengl3 opengl2 sdl2 sdl3 -DIMGUI_USE_WCHAR32

FROM debian:buster AS compile-windows
WORKDIR /cimgui
COPY --from=generator /cimgui ./

RUN wget -O - https://apt.kitware.com/keys/kitware-archive-latest.asc 2>/dev/null | gpg --dearmor - | sudo tee /usr/share/keyrings/kitware-archive-keyring.gpg >/dev/null && \
    echo "deb [signed-by=/usr/share/keyrings/kitware-archive-keyring.gpg] https://apt.kitware.com/ubuntu/ buster main" | sudo tee /etc/apt/sources.list.d/kitware.list >/dev/null && \
    sudo apt-get update && sudo apt-get install -y cmake \
    sudo apt-get install -y mingw-w64

RUN mkdir build-windows-x64 && cd build-windows-x64 && \
    cmake -G "Unix Makefiles" \
    -DCMAKE_C_COMPILER=x86_64-w64-mingw32-gcc \
    -DCMAKE_CXX_COMPILER=x86_64-w64-mingw32-g++ \
    -DCMAKE_SYSTEM_NAME=Windows \
    -DCMAKE_BUILD_TYPE=Debug \
    -DCMAKE_C_FLAGS="-DIMGUI_IMPL_API= -static" \
    -DCMAKE_CXX_FLAGS="-DIMGUI_IMPL_API= -static" \
    -DIMGUI_STATIC="no" \
    -DIMGUI_FREETYPE="no" \
    -DIMGUI_WCHAR32="yes" ..

FROM alpine AS final
WORKDIR /artifacts

COPY --from=compile-windows /cimgui/build-windows-x64/*.dll /final/win64/
COPY --from=compile-windows /cimgui/build-windows-x64/*.a /final/win64/
COPY --from=compile-windows /cimgui/build-windows-x64/*.lib /final/win64/

COPY --from=generator /cimgui/cimgui.h /final/include/cimgui.h
COPY --from=generator /cimgui/imgui/*.h /final/include/imgui/
COPY --from=generator /cimgui/imgui/backends/*.h /final/include/imgui/backends/
COPY --from=generator /cimgui/generator/output/*.json /final/definitions/

CMD ["/bin/cp", "-r", "/final/.", "/cimgui_build"]
