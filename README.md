# getting-over-it-reload-hack
This hack is to resume the last saved location or checkpoint in the game so that you do not need to start again after dropping from a point.
My bundle of thanks to [Sleeyax](https://github.com/sleeyax), which helped me to develop this peace of crap


## Installation

This hack is built using two languages C# and Python 3, C# part is taken from the author i thanked above, and it is handling most of the crucial part of the functionality
While the original author did not provided any way to hook around the hack into the game while playing, so i built a python script on the top of the C# executeable to listen to keyboard events while playing game and apply the hack on trigger.

The C# application is already compiled and built for you, just in case you want it to be customized, feel free to Install visual studio 2019 and modify according to your need

For the python side run the following command to install the appropriate packages

```bash
  pip3 install -r requirements.txt
```
    
## How to Use

If you simply want to immediately use the hack without digging into the code simply following the following simple steps and you are good to go

1)  Install the python packages by following Installation section requirements
2)  Copy the hack folder into the main directory of the game, where main executeable is residing
3)  Windows batch file is included already, simply double click the start.bat file

If everything goes well for you, the script will automatically launch the game & global hack keboard listener for you.

## How to Apply Hack?

So basically the idea is your progress is saved when we quit the game and, it is resumed only when we continue the game, follow the steps below to apply hack in game

#### Save a Checkpoint
First on a location where you think you are stable and you think it need to be saved, simply quit the game and type the keys CTRL + SHIFT + S
just like CTRL + S it will will save your game as a checkpoint, you can safely continue your game

#### Load last saved Checkpoint
At any point of game if you think you are droped, or simply you want to resume from the last saved checkpoint again quit the game, and hit CTRL + SHIFT + L
which indicates the load last saved checkpoint again continue the game Voila!! you will be resumed from the saved point


## FAQ

#### What do i need to run this Hack?

You just need to have Python 3 installed & .Net framework 4.5 for the executeable to run, simply follow instalattion steps and nothing fancy here

#### What if the checkpoint is not Saving

The executeable needs regestery access to read game current progress, and obviously needs file system access to save local file, check if you have priviliges to read from the regestery and write to a file, try to run batch file as admin to see if it works for you.

#### What if i want to save multiple checkpoints and load them later

The executeable i built supports this behaviour but python script rewrites the previous checkpoint with the newone instead of creating new checkpoint, so the point is you have everything you want, feel free to make any changes, do not be a monkey and expect me to do every thing for you. If you are not programmer then this hack is not meant for you.



## Related

Here is the related project with even more options, hacks and a nicely crafted GUI

[GOI-cheats](https://github.com/sleeyax/GOI-cheats)