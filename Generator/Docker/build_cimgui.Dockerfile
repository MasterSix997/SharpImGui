FROM alpine AS sources
WORKDIR /cimgui
RUN apk update && apk add --no-cache git build-base
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimgui.git .
RUN git submodule update --init --recursive

FROM alpine AS generator
WORKDIR /cimgui
COPY --from=sources /cimgui ./
RUN apk add --no-cache luajit lua5.1-dev gcc musl-dev
# Executar o gerador usando LuaJIT com as opções especificadas
WORKDIR /cimgui/generator
RUN luajit generator.lua gcc "internal noimstrv comments" glfw opengl3 opengl2 sdl2 sdl3 -DIMGUI_USE_WCHAR32

FROM ubuntu:20.04 AS compile-windows
WORKDIR /cimgui
COPY --from=sources /cimgui ./
RUN apt-get update && apt-get install -y mingw-w64 cmake ninja-build
# Compilar para Windows x64
RUN cmake -Bbuild-windows-x64 -G Ninja -DCMAKE_SYSTEM_NAME=Windows -DCMAKE_C_COMPILER=x86_64-w64-mingw32-gcc -DCMAKE_CXX_COMPILER=x86_64-w64-mingw32-g++ \
    -DCIMGUI_BUILD_SHARED=OFF -DCIMGUI_BUILD_STATIC=ON -DIMGUI_WCHAR32=ON .
RUN cmake --build build-windows-x64 --config Release

FROM alpine AS final
WORKDIR /artifacts
COPY --from=compile-windows /cimgui/build-windows-x64/cimgui.dll /final/win64/cimgui.dll

COPY --from=generator /cimgui/cimgui.h /final/cimgui.h
COPY --from=generator /cimgui/generator/output/definitions.json /final/definitions.json
COPY --from=generator /cimgui/generator/output/structs_and_enums.json /final/structs_and_enums.json
COPY --from=generator /cimgui/generator/output/typedefs_dict.json /final/typedefs_dict.json

CMD ["/bin/cp", "-r", "/final/.", "/cimgui_build"]