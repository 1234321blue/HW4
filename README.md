# HW4
## Devlog
This project utilizes the MVC design model well, especially in the view and control aspects of it. The main control aspects of the code come from the Birb script, which is what allows most of the in game actions to happen such as the bird being able to flap, detecting when the bird scores a point, and ending the game when the bird crashes into something. This class has the logic behind the game, which also triggers the events that tell the view side of our classes, the AudioUI class, that then reacts to the events with view aspects of the MVC design model. In conjunction with this, to further decouple our code, instead of having the AudioUI class contain information about the Birb class in order to utilize the events, we instead use a Singleton, the Locator class, to seperate out how coupled together our code would be. 

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites