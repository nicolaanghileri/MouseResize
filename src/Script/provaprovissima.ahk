#Space::

    MsgBox, provaprovissima
    MouseGetPos , X, Y, Win, Cont, 
        WinGetTitle, WindowTitle, ahk_id %Win%
        WinGetPos , XWin, YWin,,, %WindowTitle%,
        ;CoordMode, Mouse, Relative
        WinX = %XWin%
        WinY = %YWin%
        MouseX = %X%
        MouseY = %Y%
        Loop{
                ;MsgBox, Mers           
                MouseGetPos , Xn, Yn,
                ;ToolTip, %Xn% + %Yn% 
                spostX := Xn - MouseX
                spostY := Yn - MouseY
                WinMove, %WindowTitle% , , , , 1000, 1000,
                MouseX := Xn
                MouseY := Yn
                ;WinGetPos , XWin, YWin,,, %WindowTitle%,
                ;WinX := XWin
                ;WinY := YWin
                ToolTip, %spostY%x%spostX%

        }