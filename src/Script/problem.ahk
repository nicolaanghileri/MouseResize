
#SingleInstance, Force


IniRead, resKeyboard, config.ini, Keys, ResizeKeyboard,

resKey = %resKeyboard%
MouseGetPos , X, Y, Win, Cont, 
ToolTip, Debug %resKey%

Hotkey, %resKey% , ResizeWindow

ResizeWindow:
	if (GetKeyState(resKey, "P") And ){
		ToolTip, Debug %resKey% and pressed
	}else{
		ToolTip, Debug %resKey% alone
	}
    Goto, ResizeWindow
	


