# Kyles-Fantastic-Dialogue-System
A simple dialogue system designed for Unity's built-in UI components. Allows users to specify how many characters they want speaking, how many lines will be spoken, and which side of the screen they will be speaking from.
## Installation
Make sure Unity 2020.2.2f1 is installed, then open main folder as a Unity project.
## Usage
### Setting Up the Scene
Make a canvas in any scene. 
Add an empty child to the Canvas attach the DialogueDisplay script to it. 
Create a child to the Dialogue Display game object to add the SpeakerUI script to it.
Add 3 new child objects to the SpeakerUI object:
  -Image object to assign as the SpeakerUI's "Portrait" attribute
  -2 Text objects to assign as the SpeakerUI's "Full Name" and "Dialogue" attributes
Customize with Panels or more Images to change the dialogue UI as needed. 
### Setting up the Scriptables Objects
Character objects have 2 attributes, Full Name and Portrait
  -Full Name is a string that will be your character's name
  -Portrait is the sprite that will appear whenever your character is the active speaker
  
Conversation objects have 2 attribute fields, Characters and Lines
  -Characters is a list of all characters in a conversation
  -Lines is list containing structs of information about each line of dialogue: What character is speaking, which side they are speaking from, and the actual text they are speaking

Side objects are simply flags currently only used to determine which side of the screen a character is facing. It only has one attribute: Side
  -Side is a string used a flag in the DialogueDisplay, the only two used currently are "Left" and "Right".

###Testing
Spacebar advances dialogue once implemented into the scene. If null characters or characters will null values are added to conversations, they will log warnings in the Unity console and not display anything in the game. 

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update test scenes as appropriate.
