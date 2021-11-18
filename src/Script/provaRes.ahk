;#SingleInstance, Force

#Space::
CoordMode, Mouse, Relative
MsgBox, Partito
MouseGetPos , , , Win, Cont, 
WinGetTitle, WindowTitle, ahk_id %Win%
;WinGetPos , XWin, YWin,,, %WindowTitle%,
;WinGetPos , XWin, YWin, Width, Height, %WindowTitle%
WinGetPos, XWin, YWin, Width, Height, %WindowTitle%
;MsgBox, %WindowTitle% is at %X%`,%Y% and its size is %W%x%H%
CoordMode, Mouse, Relative
;MouseY = %Y%
;MouseX = %X%
WinWidth = %Width%
WinHeight = %Height%
XWinn = %XWin%
;MsgBox, %WindowTitle%
;MsgBox, %Width% %Height%
Loop{
    MouseGetPos , valX, valY,
    H = 0
    W = 0
    Sector := 0

    Sec := getSector(valX,valY,WinWidth,WinHeight)
    ToolTip, %Sec%
    Switch Sec{ 
        case 4:
            resize4()
            return  
    }
}

RETURN ;

getSector(X,Y,WinWidth,WinHeight)
{
    S := -1
    if(X > 0 and X < WinWidth/2){
        if(Y > 0 and Y < WinHeight/2){
            S := 1
        }else if(Y > WinHeight/2 and Y < WinHeight){
            S := 3
        } 
    }else if(X > WinWidth/2 and X < WinWidth){
        if(Y > 0 and Y < WinHeight/2){
            S := 2
        }else if(Y > WinHeight/2 and Y < WinHeight){
            S := 4
        } 
    }
    return %S%
}

resize4()
{
    MsgBox, provaprovissima
    MouseGetPos , X, Y, Win, Cont, 
    WinGetTitle, WindowTitle, ahk_id %Win%
    WinGetPos , XWin, YWin,Width,Height, %WindowTitle%,
    ;WinX = %XWin%
    ;WinY = %YWin%
        MouseX = %X%
        MouseY = %Y%
        WinHeight = %Height%
        WinWidth = %Width%
    
        MouseGetPos , Xn, Yn,
        ToolTip, %Xn% + %Yn% 
        spostX := Xn - MouseX
        spostY := Yn - MouseY
        WinMove, %WindowTitle% , , , , WinWidth + spostX , WinHeight + spostY,
        ToolTip, 
        MouseX := Xn
        MouseY := Yn
        WinHeight := WinHeight + spostY
        WinWidth := WinWidth + spostX
    
}


