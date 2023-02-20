@echo off

REM  Maximizing the batch window
if not "%1" == "max" start /MAX cmd /c %0 max & exit/b

REM Clearing all the screen content
cls

REM starting the game in separate thread
start ..\GettingOverIt.exe

REM Starting the global hook listener
py hook.py