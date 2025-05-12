FROM alpine AS sources
WORKDIR /cimgui
RUN apk update && apk add --no-cache git build-base
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimgui.git
RUN git clone --depth 1 --recursive https://github.com/JunaMeinhold/cimnodes.git

FROM alpine AS generator
WORKDIR /cimgui
COPY --from=sources /cimgui ./
RUN apk add --no-cache luajit lua5.1-dev gcc musl-dev
WORKDIR /cimgui/cimnodes/generator
RUN luajit generator.lua gcc

# ========== Windows ==========
FROM ubuntu:20.04 AS compile-windows-x64
WORKDIR /cimgui
COPY --from=generator /cimgui .
ARG BUILD_TYPE=Release
RUN apt-get update && apt-get install -y mingw-w64
RUN apt-get install -y cmake
RUN apt-get install -y libfreetype6-dev
WORKDIR /cimgui/cimnodes/build
RUN cmake -DCIMGUI_API='extern "C" __declspec(dllexport)' \
    -DCMAKE_SYSTEM_NAME=Windows \
    -DCMAKE_C_COMPILER=x86_64-w64-mingw32-gcc \
    -DCMAKE_CXX_COMPILER=x86_64-w64-mingw32-g++ \
    ..
RUN cmake --build . --config $BUILD_TYPE --target cimnodes

FROM ubuntu:20.04 AS compile-windows-x86
WORKDIR /cimgui
COPY --from=generator /cimgui .
ARG BUILD_TYPE=Release
RUN apt-get update && apt-get install -y mingw-w64
RUN apt-get install -y cmake
WORKDIR /cimgui/cimnodes/build
RUN cmake -DCIMGUI_API='extern "C" __declspec(dllexport)'  \
    -DCMAKE_SYSTEM_NAME=Windows  \
    -DCMAKE_C_COMPILER=i686-w64-mingw32-gcc  \
    -DCMAKE_CXX_COMPILER=i686-w64-mingw32-g++  \
    ..
RUN cmake --build . --config $BUILD_TYPE --target cimnodes

# ========== Linux ==========
FROM gcc AS compile-linux-x64
WORKDIR /cimgui
COPY --from=generator /cimgui .
ARG BUILD_TYPE=Release
RUN apt-get update && apt-get install -y cmake
WORKDIR /cimgui/cimnodes/build
RUN cmake -DCIMGUI_API='extern "C" __attribute__((visibility("default")))' \
    ..
RUN cmake --build . --config $BUILD_TYPE --target cimnodes

FROM ubuntu:20.04 AS compile-linux-x86
WORKDIR /cimgui
COPY --from=generator /cimgui .
ARG BUILD_TYPE=Release
RUN DEBIAN_FRONTEND=noninteractive
RUN apt-get update && apt-get install -y cmake gcc-multilib g++-multilib
WORKDIR /cimgui/cimnodes/build
RUN cmake -DCIMGUI_API='extern "C" __attribute__((visibility("default")))' \
    -DCMAKE_C_FLAGS="-m32" \
    ..
RUN cmake --build . --config $BUILD_TYPE --target cimnodes

FROM ubuntu:20.04 AS compile-linux-arm64
WORKDIR /cimgui
COPY --from=generator /cimgui .
ARG BUILD_TYPE=Release
RUN DEBIAN_FRONTEND=noninteractive
RUN apt-get update && apt-get install -y cmake gcc-aarch64-linux-gnu g++-aarch64-linux-gnu
WORKDIR /cimgui/cimnodes/build
RUN cmake -DCIMGUI_API='extern "C" __attribute__((visibility("default")))' \
    -DCMAKE_SYSTEM_NAME=Linux \
    -DCMAKE_C_COMPILER=aarch64-linux-gnu-gcc \
    -DCMAKE_CXX_COMPILER=aarch64-linux-gnu-g++ \
    ..
RUN cmake --build . --config $BUILD_TYPE --target cimnodes

FROM alpine AS final
WORKDIR /artifacts

COPY --from=compile-windows-x64 /cimgui/cimnodes/build/cimnodes.dll /final/build/win/x64/cimnodes.dll
COPY --from=compile-windows-x86 /cimgui/cimnodes/build/cimnodes.dll /final/build/win/x86/cimnodes.dll

COPY --from=compile-linux-x64 /cimgui/cimnodes/build/cimnodes.so /final/build/linux/x64/cimnodes.so
COPY --from=compile-linux-x86 /cimgui/cimnodes/build/cimnodes.so /final/build/linux/x86/cimnodes.so
COPY --from=compile-linux-arm64 /cimgui/cimnodes/build/cimnodes.so /final/build/linux/arm64/cimnodes.so

COPY --from=generator /cimgui/cimnodes/cimnodes.h /final/include/cimnodes.h
COPY --from=generator /cimgui/cimnodes/imnodes/*.h /final/include/imnodes/
COPY --from=generator /cimgui/cimnodes/generator/output/*.json /final/definitions/

CMD ["/bin/cp", "-r", "/final/.", "/cimgui_build"]
