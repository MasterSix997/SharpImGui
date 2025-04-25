@echo off
title Building Natives

setlocal enabledelayedexpansion

set scriptPath=%~dp0

echo running from %scriptPath%

set cimplot3dPath=%scriptPath%cimplot3d

:: Build docker image for building natives
docker build -f build_cimplot3d.Dockerfile -t build_cimplot3d:cimplot3d .

echo --- BUILT ---

set folder="cimplot3d"
if not exist "%folder%" (
    mkdir "%folder%"
) else (
    echo "%folder%" dir is already present
    echo Clearing "%folder%" directory
    rmdir /s /q "%folder%"
)

:: Execute docker container to build natives
docker run --rm -i -v "%scriptPath%cimplot3d:/cimgui_build" build_cimplot3d:cimplot3d

echo --- RAN ---

echo Press any key to exit...
pause >nul