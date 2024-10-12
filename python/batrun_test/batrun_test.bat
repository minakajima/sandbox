@echo off
"C:\Data\code\sandbox\python\batrun_test\dist\batrun_test.exe" 2
echo Return code: %errorlevel%
if %errorlevel% equ 1 (
    echo Error: The return code is 1
)


"C:\Data\code\sandbox\python\batrun_test\dist\batrun_test.exe" 1
echo Return code: %errorlevel%

if %errorlevel% equ 1 (
    echo Error: The return code is 1
)

pause