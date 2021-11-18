#SingleInstance, Force
#Space::
    MsgBox, provaprovissima
    MouseGetPos , X, Y, Win, Cont, 
    WinGetTitle, WindowTitle, ahk_id %Win%
    WinGetPos , XWin, YWin,Width,Height, %WindowTitle%,
    CoordMode, Mouse, Screen
    WinX = %XWin%
    WinY = %YWin%
    MouseX = %X%
    MouseY = %Y%
    WinHeight = %Height%
    WinWidth = %Width%
    Loop{
        MouseGetPos , Xn, Yn,
        spostX := Xn - MouseX
        spostY := Yn - MouseY
        ToolTip, SpX:%spostX%SpY:%spostY%
        ;SECTOR 1:
        ;SECTOR 1:WinMove, %WindowTitle% , , WinX + spostX, WinY + spostY , WinWidth - spostX, WinHeight - spostY
        ;SECTOR 3: WinMove, %WindowTitle% , , WinX + spostX, , WinWidth - spostX, WinHeight + spostY
        ;WinHeight := WinHeight + spostY
        ;WinWidth := WinWidth - spostX
        ;SECTOR 2: WinMove, %WindowTitle% , , , WinY + spostY, WinWidth + spostX, WinHeight - spostY
        ;SECTOR 4: WinMove, %WindowTitle% , , , , WinWidth + spostX , WinHeight + spostY,

        ;Aggiornare valori
        MouseX := Xn
        MouseY := Yn
        WinGetPos , XWin, YWin, Width, Height, %WindowTitle%,
        WinY := YWin
        WinX := XWin
        WinHeight := Height
        WinWidth := Width
    }

    