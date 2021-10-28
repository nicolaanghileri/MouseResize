#SingleInstance, Force
;author Nicola Anghileri
;version 07.10.2021 last changes: 28.10.2021

;Reads the infos for resize hotkey in config.ini
IniRead, resKeyboard, config.ini, Keys, ResizeKeyboard,
IniRead, resMouse, config.ini, Keys, ResizeMouse,

;Reads the infos for window shift hotkey in config.ini
IniRead, shiftKeyboard, config.ini, Keys, ShiftKeyboard,
IniRead, shiftMouse, config.ini, Keys, ShiftMouse,

resKey = %resKeyboard%
resMou = %resMouse%
combiResize = %resKey% & %resMou%

shiftKey = %shiftKeyboard%
shiftMou = %shiftMouse%
combiShift = %shiftKey% & %shiftMou%

Hotkey, %combiResize% , ResizeWindow, On
;Hotkey, %combiShift% ,  ShiftWindow

;After this command the labels will not auto-execute
RETURN ;

Shift:
    MouseGetPos , X, Y, Win, Cont, 
    WinGetTitle, WindowTitle, ahk_id %Win%
    WinGetPos , XWin, YWin,,, %WindowTitle%,
    CoordMode, Mouse, Screen
    WinX = %XWin%
    WinY = %YWin%
    MouseX = %X%
    MouseY = %Y%
    ;MsgBox, %WindowTitle%
    Loop{
        if (GetKeyState(resKey, "P") And GetKeyState(resMou, "P")){            
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
        }else{
            ToolTip,
            Break
        }  
    }
Return

ResizeWindow:
    Gosub, Shift
    Goto, ResizeWindow

ShiftWindow:
    MsgBox, WindowShift
    ExitApp,





