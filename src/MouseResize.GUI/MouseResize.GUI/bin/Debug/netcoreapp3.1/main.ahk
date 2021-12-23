#SingleInstance, Force
;author Nicola Anghileri
;version 07.10.2021 last changes: 22.12.2021

;Reads the infos for resize hotkey in config.ini
IniRead, resKeyboard, config.ini, Keys, ResizeKeyboard,
IniRead, resMouse, config.ini, Keys, ResizeMouse,

;Reads the infos for window shift hotkey in config.ini
IniRead, shiftKeyboard, config.ini, Keys, ShiftKeyboard,
IniRead, shiftMouse, config.ini, Keys, ShiftMouse,

;Assigning the values from ini file to variables (Combination for resize).
resKey = %resKeyboard%
resMou = %resMouse%
combiResize = %resKey% & %resMou%

;Assigning the values from ini file to variables (Combination for shifting).
shiftKey = %shiftKeyboard%
shiftMou = %shiftMouse%
combiShift = %shiftKey% & %shiftMou%

;Added to system tray the option to open GUI.
Menu, Tray, Add, GUI, gui

;Creating the triggers for the combination created at lines 16 and 21.
Hotkey, %combiResize% , ResizeWindow, On
Hotkey, %combiShift% ,  ShiftWindow, On

;CoordMode sets the system of reference for the Mouse position, where it is based on The total screen.
CoordMode, Mouse, Screen

;Helper variable that contains the choosen option, 1 for resize, 2 for shift.
flag := -1


;After this command the labels will not auto-execute
RETURN ;

gui:
    Run, MouseResize.GUI.exe

;Label Main contains all the statments for shifting and resizing.
Main:
    ;Collecting all important infos for resizing and/or shifting, Current x,y positionn of the current screen and mouse,
    ;the WindowTitle under the mouse cursor, and the Height and Width of that window.
    MouseGetPos , X, Y, Win, Cont, 
    WinGetTitle, WindowTitle, ahk_id %Win%
    WinGetPos, XWin, YWin,Width,Height, %WindowTitle%,
    WinX = %XWin%
    WinY = %YWin%
    MouseX = %X%
    MouseY = %Y%
    WinHeight = %Height%
    WinWidth = %Width%
    
    Loop{
        Sec := getSector(Xn,Yn,WinX,WinY,WinWidth,WinHeight)
        MouseGetPos , Xn, Yn,
        WinGetPos, XInfo, YInfo,WInfo,HInfo, %WindowTitle%,
          
        ;ToolTip, %Xn% + %Yn% 
        spostX := Xn - MouseX
        spostY := Yn - MouseY

        if(flag == 1){
            ;Check if key-combination for shifting window is pressed.
            if (GetKeyState(resKey, "P") And GetKeyState(resMou, "P")){ 
                ;Print infos next to the cursor.
                ToolTip, "X: "%XInfo%" Y: "%YInfo%" W: "%WInfo% " H: "%Height%        
                WinMove, %WindowTitle% , , WinX + spostX,WinY + spostY ,  
            }else{
                flag := -1
                ToolTip,
                Break
            }
        }else if(flag == 2){
            ;Check if key-combination for resize is pressed.
            if (GetKeyState(shiftKey, "P") And GetKeyState(shiftMou,"P")){
                ;Print infos next to the cursor.
                ToolTip, "X: "%XInfo%" Y: "%YInfo%" W: "%WInfo% " H: "%Height%
                Sec := getSector(Xn,Yn,WinX,WinY,WinWidth,WinHeight)
                Switch Sec
                {
                    Case 1:
                        WinMove, %WindowTitle% , , WinX + spostX, WinY + spostY , WinWidth - spostX, WinHeight - spostY  
                    Case 2:
                        WinMove, %WindowTitle% , , , WinY + spostY, WinWidth + spostX, WinHeight - spostY
                    Case 3:
                        WinMove, %WindowTitle% , , WinX + spostX, , WinWidth - spostX, WinHeight + spostY
                    Case 4:
                        WinMove, %WindowTitle% , , , , WinWidth + spostX , WinHeight + spostY,
                }
            }else{
                flag := -1
                ToolTip,
                Break
            }
        }
        ;Update all the new values:
        MouseX := Xn
        MouseY := Yn
        WinGetPos , XWin, YWin, Width, Height, %WindowTitle%,
        WinY := YWin
        WinX := XWin
        WinHeight := Height
        WinWidth := Width
    }
Return
    
;Label for resize.
ResizeWindow:
    flag := 1
    Gosub, Main
    
;Label for shifting.
ShiftWindow:
    flag := 2
    Gosub, Main


;returns the sector in wich the mouse is positioned in the window. 1 - 2 - 4
getSector(X,Y,WinX, WinY,WinWidth,WinHeight)
{
    S := -1
    if(X > WinX and X < (WinWidth/2 + WinX)){
        if(Y > WinY and Y < (WinHeight/2 + WinY)){
            S := 1
        }else if(Y > (WinY + WinHeight/2) and Y < (WinY +WinHeight)){
            S := 3
        } 
    }else if(X > (WinX + WinWidth/2) and X < (WinX + WinWidth)){
        if(Y > WinY and Y < (WinY + WinHeight/2)){
            S := 2
        }else if(Y > (WinY + WinHeight/2) and Y < (WinY +WinHeight)){
            S := 4
        } 
    }
    return %S%
}





