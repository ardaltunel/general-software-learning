@echo off
title Phantaso - Windows 10 Etkinlestirme
:menu
cls

NET SESSION >nul 2>&1
if %errorLevel% neq 0 (
    echo Lutfen yonetici olarak calistirin
    echo.
    pause
    exit
)

:admincheck

echo Windows surumunuzu seciniz:
echo 0. Surumu Nasil Ogrenirim
echo 1. Home
echo 2. Home N
echo 3. Home Single Language
echo 4. Home Country Specific
echo 5. Professional
echo 6. Professional N
echo 7. Education
echo 8. Education N
echo 9. Enterprise
echo 10. Enterprise N

set /p choice=Seciminizi yapin (0-10): 

if "%choice%"=="1" (
    slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="2" (
    slmgr /ipk 3KHY7-WNT83-DGQKR-F7HPR-844BM
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="3" (
    slmgr /ipk 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="4" (
    slmgr /ipk PVMJN-6DFY6-9CCP6-7BKTT-D3WVR
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="5" (
    slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="6" (
    slmgr /ipk MH37W-N47XK-V7XM9-C7227-GCQG9
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="7" (
    slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="8" (
    slmgr /ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="9" (
    slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="10" (
    slmgr /ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4
    slmgr /skms kms8.msguides.com
    slmgr /ato
    pause
) else if "%choice%"=="0" (
    echo.
    echo Ayarlara girin
    echo Sistem secenegine tiklayin
    echo Hakkinda kisminda gorebilirsiniz
    echo.
    pause
    goto menu
) else (
    echo.
    echo Gecersiz secim tekrar deneyin
    pause
    goto menu
)
