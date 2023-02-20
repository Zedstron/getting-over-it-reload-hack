import keyboard
from os import system

print("#" * 110)
print ("""
        d88888D d88888b d8888b. Cb .d8888.      d8888b.  .d8b.  d888888b  .o88b. db   db d88888b d8888b. 
            d8' 88'     88  `8D `D 88'  YP      88  `8D d8' `8b `~~88~~' d8P  Y8 88   88 88'     88  `8D 
           d8'  88ooooo 88   88  ' `8bo.        88oodD' 88ooo88    88    8P      88ooo88 88ooooo 88oobY' 
          d8'   88~~~~~ 88   88      `Y8b.      88~~~   88~~~88    88    8b      88~~~88 88~~~~~ 88`8b   
         d8'    88.     88  .8D    db   8D      88      88   88    88    Y8b  d8 88   88 88.     88 `88. 
        d88888P Y88888P Y8888D'    `8888Y'      88      YP   YP    YP     `Y88P' YP   YP Y88888P 88   YD 
""")
print("#" * 110, end='\n\n')

exeName = "GOI Cheat.exe"

def Log(msg, isError=False):
    msg = '[Error] ' + msg if isError else '[Info] ' + msg
    print(msg)

Log("Initializing keyboard listener")
def RunOperation(operation, name):
    Log("Applying operation {}".format(operation))
    system("\"{}\" {} {}".format(exeName, operation, name))

Log("Setting up saving hook")
keyboard.add_hotkey('ctrl+shift+s', RunOperation, args=('save', 'checkpoint'))

Log("Setting up loading hook")
keyboard.add_hotkey('ctrl+shift+l', RunOperation, args=('load', 'checkpoint'))

Log("Starting global level listener")
keyboard.wait()