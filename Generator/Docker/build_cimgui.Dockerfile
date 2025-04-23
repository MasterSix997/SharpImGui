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

FROM alpine AS final
WORKDIR /artifacts

COPY --from=generator /cimgui/cimgui.h /final/include/cimgui.h
COPY --from=generator /cimgui/imgui/*.h /final/include/imgui/
COPY --from=generator /cimgui/imgui/backends/*.h /final/include/imgui/backends/
COPY --from=generator /cimgui/generator/output/*.json /final/definitions/

CMD ["/bin/cp", "-r", "/final/.", "/cimgui_build"]
