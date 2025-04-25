FROM alpine AS sources
WORKDIR /cimgui
RUN apk update && apk add --no-cache git build-base
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimgui.git
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimplot.git

FROM alpine AS generator
WORKDIR /cimgui
COPY --from=sources /cimgui ./
RUN apk add --no-cache luajit lua5.1-dev gcc musl-dev
WORKDIR /cimgui/cimplot/generator
RUN luajit generator.lua gcc "internal"

FROM alpine AS final
WORKDIR /artifacts

COPY --from=generator /cimgui/cimplot/cimplot.h /final/include/cimplot.h
COPY --from=generator /cimgui/cimplot/implot/*.h /final/include/implot/
COPY --from=generator /cimgui/cimplot/generator/output/*.json /final/definitions/

CMD ["/bin/cp", "-r", "/final/.", "/cimgui_build"]
