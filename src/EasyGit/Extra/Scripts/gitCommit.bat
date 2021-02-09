@echo off
@echo off
@echo off
@echo off
@echo off
@echo off
@echo off
@echo off

rem the fact that I have to turn @echo off a few times annoys me.
rem if anyone can make this work better then setting it to off like this
rem please make a pull request.

title Please wait.
cls
echo DO NOT CLOSE THIS WINDOW. IT WILL CLOSE ON ITS OWN.
echo.
REM %1 = commit message
rem %2 = path
rem %3 = set if commit & push or pull
rem %4 = set username
rem %5 = set email

if %3=="pull" goto pull
if %3=="push" goto commit
if %3=="setuser" goto setuser
goto error


:setuser
echo setting username to: %4
git config --global user.name %4
echo setting email to: %5
git config --global user.email %5

goto done

:pull
echo Pulling
echo.
cd %2
echo Changed folder to %2
echo.
git pull

goto done



:commit
echo Commiting...
echo.
cd %2
echo Changed folder to %2
echo.
git add .
git commit -m %1
git push

goto done

:error
echo There was an error.
echo failed to %3


:done

echo Done.
echo This window will close in 30 seconds
ping localhost -n 30 >nul