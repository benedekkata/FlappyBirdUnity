# FlappyBirdUnity project

This project was built in Unity as a home project to learn the Engine's basics.

## Result

**Main menu UI**

![image](https://github.com/benedekkata/FlappyBirdUnity/assets/35570314/63c644b0-d070-463b-a274-ca0d60425d54)

**In-Game view**

![image](https://github.com/benedekkata/FlappyBirdUnity/assets/35570314/c18cda5b-a4a4-4277-837a-b09c3574c253)

**Game Over screen**

![image](https://github.com/benedekkata/FlappyBirdUnity/assets/35570314/7337290c-a6de-4827-8b06-7f114b852eec)

## Main milestones

### Core Game Mechanincs

* Using the `space` button on the keyboard the player can make Flappy go higher
* With some pipe prefabs I made a pipe spawner that will spawn pipes periodically
* Pipes are deleted if they leave the screen to save memory
* Flappy will collide with the pipes and with the screen edges and that will end the game
* When Flappy passes a pipe it will increase the player's points
* When the game is over a corresponding screen will allow a player to exit or restart the game

### Sprite animation

* Using my own sprite sheet I created a 2 piece, sprite animation to make Flappy's wings flap

### Game UI

* There are 2 different UI screens in this game
* The main menu is in its own scene and it allows the player to start the game or exit the game
* The Game Over screen is part of the main game scene, it is hidden and shown based on the game's state
* The Game Over screen has a special background blure behind it, which was achieved by using Post Process Volume on the main camera
* I used a custom script to have drop-shadow behind some of the buttons, and a plugin to have the rounded corners

### Particle system

* There are randomly generated clouds in the main game view
* I used Unity's particle system to make them appear and disappear periodically

### Sounds

* When Flappy passes a pipe and gets a point it plays a _ping_ sound
* I used a free sound effect on the pipe prefab's middle component's Audio Source

### High Score

* The player's high score is saved and displayed via PlayerPrefs

## Assets and plugins used

I created most of the graphic assets in the game with Clip Art Studio Paint.

I've used the following free font: [Free Pixel Font - Thaleah](https://assetstore.unity.com/packages/2d/fonts/free-pixel-font-thaleah-140059)

Besides the main Unity packages I've used [Unity-UI-Rounded-Corners](https://github.com/kirevdokimov/Unity-UI-Rounded-Corners)
