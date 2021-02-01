
cls
@echo off
cls
title Python Preview
echo Starting Python Preview...
echo.
echo Please note that you will need Python to be installed on the PATH,
echo otherwise, this function will not work.
echo.
echo.
echo Starting Web server in 5 seconds...
ping localhost -n 5 >nul
echo Starting Python (Modual: http.server)
echo (File location: %1)
cd %1
echo.
echo The program will attempt to open your browser and load the page in
echo 5 seconds. If the python server has not loaded by then, wait for it
echo to start, and then reload the page the program opens.
echo.
echo.
echo To close shutdown the python server,
echo press CTRL + C on this window, and answer
echo n or no to the prompt.
python -m http.server 8000
exit