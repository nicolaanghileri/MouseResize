!LButton::
MsgBox, Partito
    MouseGetPos , X, Y, Win, Cont, 
    WinGetTitle, WindowTitle, ahk_id %Win%
    WinGetPos , XWin, YWin,,, %WindowTitle%,
    CoordMode, Mouse, Screen
    WinX = %XWin%
    WinY = %YWin%
    MouseX = %X%
    MouseY = %Y%
    
    MouseGetPos , Xn, Yn,
    ToolTip, %Xn% + %Yn% 
    spostX := Xn - MouseX
    spostY := Yn - MouseY
    WinMove, %WindowTitle% , , WinX + spostX,WinY + spostY ,
    MouseX := Xn
    MouseY := Yn
    WinGetPos , XWin, YWin,,, %WindowTitle%,
    WinX := XWin
    WinY := YWin


