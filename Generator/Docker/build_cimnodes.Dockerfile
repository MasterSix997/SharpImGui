FROM alpine AS sources
WORKDIR /cimgui
RUN apk update && apk add --no-cache git build-base
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimgui.git
RUN git clone --depth 1 --recursive https://github.com/cimgui/cimnodes.git

FROM alpine AS generator
WORKDIR /cimgui
COPY --from=sources /cimgui ./
RUN apk add --no-cache luajit lua5.1-dev gcc musl-dev
WORKDIR /cimgui/cimnodes/generator
RUN luajit generator.lua gcc

FROM alpine AS final
WORKDIR /artifacts

COPY --from=generator /cimgui/cimnodes/cimnodes.h /final/include/cimnodes.h
COPY --from=generator /cimgui/cimnodes/imnodes/*.h /final/include/imnodes/
COPY --from=generator /cimgui/cimnodes/generator/output/*.json /final/definitions/

CMD ["/bin/cp", "-r", "/final/.", "/cimgui_build"]
