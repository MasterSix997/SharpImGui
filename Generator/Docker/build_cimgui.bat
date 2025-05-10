@echo off
title Building Natives

setlocal enabledelayedexpansion

set scriptPath=%~dp0

echo running from %scriptPath%

set cimguiPath=%scriptPath%cimgui

:: Build docker image for building natives
docker build -f build_cimgui.Dockerfile -t build_cimgui:cimgui .

echo --- BUILT ---

set folder="cimgui"
if not exist "%folder%" (
    mkdir "%folder%"
) else (
    echo "%folder%" dir is already present
    echo Clearing "%folder%" directory
    rmdir /s /q "%folder%"
)

:: Execute docker container to build natives
docker run --rm -i -v "%scriptPath%cimgui:/cimgui_build" build_cimgui:cimgui

echo --- RAN ---