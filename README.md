# GDIM32 In Class Activities

## w1


### w2

## 1
![4fc29f50fcc32c5aa69019fe53639c8](https://github.com/user-attachments/assets/694bf784-9258-4c54-aa3e-99b7817b5416)


## 2
[comm]([URL](https://github.com/UCI-GDIM32-W25/mg2-chengzi3277/commit/ddd7e5f3cc00eb42a2ef3a5330568edbab46cb8f))


### w3

## Activities 0-2
Ruichen Ma
Chengxi Jiang

## Activity 3


![0115eb1b7c5d03736691295a52e03655](https://github.com/user-attachments/assets/fa57b0a3-45c3-4d21-b6d2-7f84a6eadf53)

### w4

## 1
Ruichen Ma
Chengxi Jiang

## 2
When the game runs, only one Locator remains in the Scene. The first Locator sets the static Instance, and any additional Locator objects detect that Instance is already taken and destroy themselves. This enforces the Singleton pattern by ensuring only one Locator exists at runtime.

## 3
![f2f5e63aaca899b292ff673d49e70905](https://github.com/user-attachments/assets/4c12459c-f844-407c-bf50-e5735793f794)

## 4
[comm]([URL](https://github.com/UCI-GDIM32-W25/HW4/compare/main...chengzi3277:HW4:main))
i build the envirment and the bird. And i write the code of the bird, make it can jump and check if it dead



### w5

## 1
I think the design of these interfaces and abstract classes is generally good because it helps separate responsibilities and keeps the code organized. Using interfaces makes it easier to change or extend systems like scoring or audio without rewriting existing code, and abstract classes reduce repeated logic by sharing common behavior. If I were building a project with items like these, I would mostly keep the same design, but I might simplify it if the project stayed small. For a short assignment, some abstractions can feel unnecessary, but for a larger project, this structure would make the code easier to manage, read, and expand over time.

## 2
the Model is the classes that store game data like objects like weapons and material, the View is the UI scripts that display that data on screen and the text that npc say.
the Controller is the gameplay scripts that handle player input and interactions and update the game state.

## 3

# example 1
Model: ScriptableObjects store beat data (key, screen position, song timing).
Control: Manages beat spawning, input detection, and hit/miss judgment.
View: Handles beat visuals/animations, SFX, and hit/miss feedback.
Singleton GameController syncs audio-timing, input, and feedback via events.

# example 2
Model: ScriptableObjects store core character data like health, base movement, unique attack.
Control: Base CharacterController handles shared logic (health, movement); unique attack/movement logic is modular per character.
View: Manages character meshes, animations, and visual/audio feedback for abilities.
Singleton GameController syncs character state, ability usage, and feedback via events.
# example 3
View:InventoryIU, DialogueUI, animation, SFX.

Control:Player NPC Object(plant, stone)

Model:Items, NPC, Object (ScriptableObject)

Singleton: GameController (sent event)

For this Stardew Valley-like farming game, we structure it following the Model-View-Control (MVC) pattern with a Singleton GameController:The Model layer uses ScriptableObjects to store core data for Items, NPCs, and farm objects (plants, stones).The Control layer manages interactions between the Player, NPCs, and farm objects (plants, stones).The View layer handles all visual/audio feedback, including InventoryUI, DialogueUI, character animations, and sound effects (SFX).A Singleton GameController acts as the central hub, sending events to connect the Model, View, and Control layers, ensuring smooth communication across all game systems.


## 4
Chengxi Jiang
RUichen Ma
Eric Wei

Proposal [final w5](https://docs.google.com/document/d/1xih16oloKwzPrgx0m7rAdHD8XQO2XJP5otpn2PSakoM/edit?tab=t.0#heading=h.y4j3q551ojs1)


### w6

## 1
I think I can use Gizoms to check player shooting range and enemys moving direction.
we can use it when we try to do some complex codes, it can help us check the data fast and clearly ,we dont need to think too much about it.

## 2
Chengxi Jiang
RUichen Ma
Eric Wei

Proposal [final w5](https://docs.google.com/document/d/1xih16oloKwzPrgx0m7rAdHD8XQO2XJP5otpn2PSakoM/edit?tab=t.0#heading=h.y4j3q551ojs1)


### w7

## 1 
In Unity, moving an object from one position to another using a vector offset
Original.position + offset = Target.position
surface normal ： describes the slope of the ground surface
vector addition ： creates an origin for the raycast at an offset slightly above the player's center position

## 2
Chengxi Jiang
RUichen Ma
Eric Wei

## 3
![acad9d5255935ff0c7b11ed3bbf821c](https://github.com/user-attachments/assets/058d4fd0-06fb-4f04-93b2-14ed44f4b307)


## 4
Proposal [trello w7](https://trello.com/invite/b/69951fe38563b6dbe635fcd9/ATTI28752e831b1cc64a4923d66d71eb82fc59EF406E/gdim-32-final-project-list)

## 5
Make the base background and I write some text of ui and npc talking
