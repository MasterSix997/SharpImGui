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
#RUN luajit generator.lua gcc "internal noimstrv comments constructors" opengl3
RUN luajit generator.lua gcc "internal noimstrv comments constructors" glfw opengl3 opengl2 sdl2 sdl3 -DIMGUI_USE_WCHAR32

# ========== Windows ==========
FROM ubuntu:20.04 AS compile-windows-x64
WORKDIR /cimgui
COPY --from=generator /cimgui .
RUN apt-get update && apt-get install -y mingw-w64
RUN apt-get install -y cmake
RUN apt-get install -y libfreetype6-dev
WORKDIR /cimgui/build
RUN cmake -DCIMGUI_API='extern "C" __declspec(dllexport)' \
    -DIMGUI_STATIC=OFF \
    -DIMGUI_DISABLE_OBSOLETE_FUNCTIONS=ON \
    -DIMGUI_ENABLE_FREETYPE=ON \
    -DCMAKE_CXX_FLAGS="-std=c++11 -O2 -fno-exceptions -fno-rtti -fno-threadsafe-statics" \
    -DCMAKE_SYSTEM_NAME=Windows \
    -DCMAKE_C_COMPILER=x86_64-w64-mingw32-gcc \
    -DCMAKE_CXX_COMPILER=x86_64-w64-mingw32-g++ \
    ..
RUN cmake --build . --config Release --target cimgui

FROM ubuntu:20.04 AS compile-windows-x86
WORKDIR /cimgui
COPY --from=generator /cimgui .
RUN apt-get update && apt-get install -y mingw-w64
RUN apt-get install -y cmake
WORKDIR /cimgui/build
RUN cmake -DCIMGUI_API='extern "C" __declspec(dllexport)' -DIMGUI_STATIC=OFF -DIMGUI_DISABLE_OBSOLETE_FUNCTIONS=ON -DCMAKE_CXX_FLAGS="-std=c++11 -O2 -fno-exceptions -fno-rtti -fno-threadsafe-statics" -DCMAKE_SYSTEM_NAME=Windows -DCMAKE_C_COMPILER=i686-w64-mingw32-gcc -DCMAKE_CXX_COMPILER=i686-w64-mingw32-g++ ..
RUN cmake --build . --config Release --target cimgui

# ========== Linux ==========
FROM gcc AS compile-linux-x64
WORKDIR /cimgui
COPY --from=generator /cimgui .
RUN apt-get update && apt-get install -y cmake
WORKDIR /cimgui/build
RUN cmake -DCIMGUI_API='extern "C" __attribute__((visibility("default")))' -DIMGUI_STATIC=OFF -DIMGUI_DISABLE_OBSOLETE_FUNCTIONS=ON -DCMAKE_CXX_FLAGS="-std=c++11 -O2 -fno-exceptions -fno-rtti -fno-threadsafe-statics -fPIC" ..
RUN cmake --build . --config Release --target cimgui

FROM ubuntu:20.04 AS compile-linux-x86
WORKDIR /cimgui
COPY --from=generator /cimgui .
RUN DEBIAN_FRONTEND=noninteractive
RUN apt-get update && apt-get install -y cmake gcc-multilib g++-multilib
WORKDIR /cimgui/build
RUN cmake -DCIMGUI_API='extern "C" __attribute__((visibility("default")))' -DIMGUI_STATIC=OFF -DIMGUI_DISABLE_OBSOLETE_FUNCTIONS=ON -DCMAKE_CXX_FLAGS="-std=c++11 -O2 -fno-exceptions -fno-rtti -fno-threadsafe-statics -fPIC -m32" -DCMAKE_C_FLAGS="-m32" ..
RUN cmake --build . --config Release --target cimgui

FROM ubuntu:20.04 AS compile-linux-arm64
WORKDIR /cimgui
COPY --from=generator /cimgui .
RUN DEBIAN_FRONTEND=noninteractive
RUN apt-get update && apt-get install -y cmake gcc-aarch64-linux-gnu g++-aarch64-linux-gnu
WORKDIR /cimgui/build
RUN cmake -DCIMGUI_API='extern "C" __attribute__((visibility("default")))' -DIMGUI_STATIC=OFF -DIMGUI_DISABLE_OBSOLETE_FUNCTIONS=ON -DCMAKE_CXX_FLAGS="-std=c++11 -O2 -fno-exceptions -fno-rtti -fno-threadsafe-statics -fPIC" -DCMAKE_SYSTEM_NAME=Linux -DCMAKE_C_COMPILER=aarch64-linux-gnu-gcc -DCMAKE_CXX_COMPILER=aarch64-linux-gnu-g++ ..
RUN cmake --build . --config Release --target cimgui

FROM alpine AS final
WORKDIR /artifacts

COPY --from=compile-windows-x64 /cimgui/build/cimgui.dll /final/build/win/x64/cimgui.dll
COPY --from=compile-windows-x86 /cimgui/build/cimgui.dll /final/build/win/x86/cimgui.dll

COPY --from=compile-linux-x64 /cimgui/build/cimgui.so /final/build/linux/x64/cimgui.so
COPY --from=compile-linux-x86 /cimgui/build/cimgui.so /final/build/linux/x86/cimgui.so
COPY --from=compile-linux-arm64 /cimgui/build/cimgui.so /final/build/linux/arm64/cimgui.so

COPY --from=generator /cimgui/cimgui.h /final/include/cimgui.h
COPY --from=generator /cimgui/imgui/*.h /final/include/imgui/
COPY --from=generator /cimgui/imgui/backends/*.h /final/include/imgui/backends/
COPY --from=generator /cimgui/generator/output/*.json /final/definitions/

CMD ["/bin/cp", "-r", "/final/.", "/cimgui_build"]