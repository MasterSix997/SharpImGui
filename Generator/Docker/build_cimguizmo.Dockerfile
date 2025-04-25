FROM alpine AS sources
WORKDIR /cimgui
RUN apk update && apk add --no-cache git build-base
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimgui.git
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimguizmo.git

FROM alpine AS generator
WORKDIR /cimgui
COPY --from=sources /cimgui ./
RUN apk add --no-cache luajit lua5.1-dev gcc musl-dev
WORKDIR /cimgui/cimguizmo/generator
RUN luajit generator.lua gcc "comments"

FROM alpine AS final
WORKDIR /artifacts

COPY --from=generator /cimgui/cimguizmo/cimguizmo.h /final/include/cimguizmo.h
COPY --from=generator /cimgui/cimguizmo/ImGuizmo/*.h /final/include/imguizmo/
COPY --from=generator /cimgui/cimguizmo/generator/output/*.json /final/definitions/

CMD ["/bin/cp", "-r", "/final/.", "/cimgui_build"]
