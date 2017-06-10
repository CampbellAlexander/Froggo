# Summary
Froggo is a 3D game developed in Unity where the player
hops around a swamp, collecting as many flies as it can before
the deadly crow runs in and eats you. The game is adapted
from a [TeamTreeHouse project](https://teamtreehouse.com/library/how-to-make-a-video-game-2)
but has been customized to be much more difficult and contains
automatic saving of your high score.

Hop around using WASD and collect as many flies as you can,
but watch out!
The deadly bird is out to get you, and you can't always see where it is.
It starts moving slowly, but once it gets moving it goes fast!
Watch out for its shadow, and listen for its squark
(it might give you a clue which direction it is
coming from).

# Game Model
The game consists of a 3D frog model in a 3D swamp being
chased by a 3D bird model while it collects flies.
The game makes use of colliders
to prevent the frog from leaving the swamp, for the enemy
bird to eat the frog, and for the frog to collect flies.

The camera is locked to the the player with a slight lag upon
movement to give it a 3rd-person, action style.

The enemy bird consists of a 3D animated model and physics collider, 
and it makes use of Unity's built-in pathfinding
AI to track and follow the player. The sounds it creates are in
3D stereo, so you can hear which direction it is coming from.

The player collects flies by hopping over them and colliding
with them, and this adds to the player's score. A set number
of flies is generated in random locations throughout the map, 
and whenever a fly is eaten a new one is generated in
another random location.

Music and sound clips have been included. Music is 
[Bubblegloop Swamp](https://www.youtube.com/watch?v=T9m26h0_Jxo)
from the original Banjo Kazooie Soundtrack. All other sounds
provided by TeamTreeHouse. A full mixer is used and sounds
are manually levelized appropriately.

An automatic saving feature has been implemented. The game's
running highscore is saved on your local machine, and displayed
at all times.
