@echo off
cd C:/Program Files/
echo Removing Wincust
rem wincust/*
echo Installing Wincust
echo -
move wincust
git clone https://github.com/Wolfornator/wincust/
echo -
echo Done! 
pause