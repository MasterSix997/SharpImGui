@echo off
title Building Natives

setlocal enabledelayedexpansion

set scriptPath=%~dp0

echo running from %scriptPath%

set cimguizmoPath=%scriptPath%cimguizmo

:: Build docker image for building natives
docker build -f build_cimguizmo.Dockerfile -t build_cimguizmo:cimguizmo .

echo --- BUILT ---

set folder="cimguizmo"
if not exist "%folder%" (
    mkdir "%folder%"
) else (
    echo "%folder%" dir is already present
    echo Clearing "%folder%" directory
    rmdir /s /q "%folder%"
)

:: Execute docker container to build natives
docker run --rm -i -v "%scriptPath%cimguizmo:/cimgui_build" build_cimguizmo:cimguizmo

echo --- RAN ---

echo Press any key to exit...
pause >nul