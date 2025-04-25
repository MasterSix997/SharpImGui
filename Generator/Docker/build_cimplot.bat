@echo off
title Building Natives

setlocal enabledelayedexpansion

set scriptPath=%~dp0

echo running from %scriptPath%

set cimplotPath=%scriptPath%cimplot

:: Build docker image for building natives
docker build -f build_cimplot.Dockerfile -t build_cimplot:cimplot .

echo --- BUILT ---

set folder="cimplot"
if not exist "%folder%" (
    mkdir "%folder%"
) else (
    echo "%folder%" dir is already present
    echo Clearing "%folder%" directory
    rmdir /s /q "%folder%"
)

:: Execute docker container to build natives
docker run --rm -i -v "%scriptPath%cimplot:/cimgui_build" build_cimplot:cimplot

echo --- RAN ---

echo Press any key to exit...
pause >nul