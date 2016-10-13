Unity-Tool
===================

Useful tools I use in unity 3D.


Methods
-------------
####  SetTimeout

Can be used like setTimeout in javascript, it creates a game object and in update checks if the time has come to run.

> *Example:*
```
		Tools.setTimeout(delegate(){
			print("Hello!");
		}, 10.0f); // 10 seconds
```

####  UniqueID

Will return a unique int that has not been used yet, can be used to generate id's while the game is running.

####  GetRandomInt

Returns a random int between min int and max int.


####  Shuffle

Will shuffle your list items randomly.


