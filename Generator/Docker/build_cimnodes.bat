@echo off
title Building Natives

setlocal enabledelayedexpansion

set scriptPath=%~dp0

echo running from %scriptPath%

set cimnodesPath=%scriptPath%cimnodes

:: Build docker image for building natives
docker build -f build_cimnodes.Dockerfile -t build_cimnodes:cimnodes .

echo --- BUILT ---

set folder="cimnodes"
if not exist "%folder%" (
    mkdir "%folder%"
) else (
    echo "%folder%" dir is already present
    echo Clearing "%folder%" directory
    rmdir /s /q "%folder%"
)

:: Execute docker container to build natives
docker run --rm -i -v "%scriptPath%cimnodes:/cimgui_build" build_cimnodes:cimnodes

echo --- RAN ---

echo Press any key to exit...
pause >nul