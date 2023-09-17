



press buttons to 

feed()
play() 
sleep()



If you didn't give it enough food, attention, or rest, it would die.

giving it a name and submitting a form.

internal prop : HP -> 10 -1



6 HP
[   -  |  -   |  -   |  -   |  -   |  -   |      |     |     |     ]


5 HP
[   -  |  -   |  -   |  -   |  -   |      |      |     |     |     ]


Game  (manageTamagotchi: dead ? delete : decrement HP unless user {feeds, plays, sleeps})
(
[]
)
_instances -> {obj, obj}

_instance -> {}

[] -> 
Name
if any go to zero
(feed) (play) (sleep) 0 ? die
HP 10
optional - Total Lifetime = random number between 65 and 100;

Every 10s decrements by 1
bonus:  if feed play or sleep < 10 decrements by 2 >


die()
 -> keep in memory 

It should have properties for the amount of food, attention, and rest it currently has.

There should be a main page displaying the names of all your Tamagotchi objects with the values of their properties.

Create buttons to call methods to:

Feed it, play with it, and put it to sleep. 

These methods should modify the properties of a single Tamagotchi object — such as a food property.

Make time pass. Every time you press it, the food, happiness and sleep properties of all Tamagotchis should decrease.

If any of these properties get to 0, the Tamagotchi object should report that it's dead.

At the very least, this app should include RESTful Index, New, Create, and Show routes.



