FROM alpine AS sources
WORKDIR /cimgui
RUN apk update && apk add --no-cache git build-base
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimgui.git
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimplot3d.git

FROM alpine AS generator
WORKDIR /cimgui
COPY --from=sources /cimgui ./
RUN apk add --no-cache luajit lua5.1-dev gcc musl-dev
WORKDIR /cimgui/cimplot3d/generator
RUN luajit generator.lua gcc "comments"

FROM alpine AS final
WORKDIR /artifacts

COPY --from=generator /cimgui/cimplot3d/cimplot3d.h /final/include/cimplot3d.h
COPY --from=generator /cimgui/cimplot3d/implot3d/*.h /final/include/implot3d/
COPY --from=generator /cimgui/cimplot3d/generator/output/*.json /final/definitions/

CMD ["/bin/cp", "-r", "/final/.", "/cimgui_build"]
