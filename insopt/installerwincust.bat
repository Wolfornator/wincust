@echo off
cd C:/Program Files/
IF EXIST wincust (
echo Wincust is already installed! Use the update wizard or the Reinstaller!
pause
exit
) ELSE (
git clone https://github.com/Wolfornator/wincust/
cd wincust
echo Done!
pause
exit
)
