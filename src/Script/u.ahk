if WinExist("Untitled - Notepad")
    WinKill ; Use the window found by WinExist.
else
    WinKill, Calcul
    


KeyWait Control  ; Wait for both Control and Alt to be released.
KeyWait Alt

CtrlC := Chr(3) ; Store the character for Ctrl-C in the CtrlC var.
Input, OutputVar, L1 M
if (OutputVar = CtrlC)
    MsgBox, EEOEOEADASd


;I tasti presi in considerazione sotto sono UNA PROVA, saranno prese dal file di configurazione .ini
IniRead, tastiera, config.ini, Keys, Keyboard,
IniRead, maus, config.ini, Keys, Maus,
~%tastiera% & %maus%::

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


MsgBox, %tastiera% %maus%

if (GetKeyState(%resKey%, "P") And GetKeyState(%resMou%, "P")){
		Tooltip, Stai premendo %combiResize%
		SetTimer, ToolTipOff, -250
	}


    Loop{
        if (GetKeyState(%resKey%, "P")){
            Tooltip, Shift is being held  
        }else{
            ToolTip
        }
    }

    ToolTipOff:
	ToolTip
return