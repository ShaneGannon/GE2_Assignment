# GE2_Assignment
My Assignment for Game Engines 2

STORYBOARD 

https://www.youtube.com/embed/jp0dPBVAwI4

[![IMAGE ALT TEXT](http://img.youtube.com/vi/jp0dPBVAwI4/0.jpg)](http://www.youtube.com/watch?v=jp0dPBVAwI4 "Video Title")

![](Images/storyboard.jpg)

## Story Outline

Takes place in an alternate universe to halo where humanity is a bit different (Asset sourcing was an issue), the covenant is still the same though
Follow the story of the united earth space command as they try to protect earths main defense station

ran out of time to put explosion animations in :(

## INSTRUCTIONS

To run simply go to the Intro scene and hit play.


## How It Works

The scenes are navigated using a scene manager script which takes in an input of time in seconds and a scene name to switch to after that time has elapsed. The camera management also used co routines with timing to 'shoot the scenes' properly, as reactive methods proved to yield somewhat random results, whereas using timings was far more consistent to make a movie scene.

I had experimented with some more reactive methods of scene transition but inconsistencies in the AI led to more volatile results, meaning some scenes could change too early or late based on essentially RNG.

Obstacle avoidance and collides are used throughout to stop ships from running into each other, the space station etc.

In the opening scene an arrive behavior is used to make the camera move with the ships in the scene using offset pursue and path following behaviors to orbit the space station.

During the battle the enemy ships utilize noise wandering behaviors. The human ships use offset pursue instead of pursue on account of how shooting works.

Human shooting works by firing a laser in a straight line from the front of the ship, meaning the ship must be 'pointing' at an enemy ship to hit. This is why pursue didn't work for the human scripting as thew ships would be pointing toward where the enemy ship was going, instead of where it is, meaning they would almost always miss. Using offset pursue with some obstacle avoidance, the human ships would get behind enemy ships and fire from there, allowing more to hit.

Enemy shooting works somewhat similarly however will shoot at a humans position, not just in a straight line in front, also shoots from a longer range to simulate ship archetypes (ie human, are small fast close range ships, enemy ships are long range slow moving tanks)

Both the shooting script and hit registration are controlled by colliders, with the shooting script being activated once an enemy ship is 'in range' ie. hits a large invisible collider around the ship.

Tags were used to differentiate the ship types to ensure shooting wouldn't be activated by other human ships.

Scripts like human and enemy shooting, scene and camera management management, enemy controller were mostly self made (some aspects of the shooting scripts were covered last semester), while most of the behaviors were covered during the course.

All of the assets (models, skybox, earth, music) were gotten either online or from the asset store as i felt they were much better quality than what i could produce through something like blender. The ony exception to this was the voice acting which i did myself, however lack of a proper mic lead to some quality and volume issues.

Overall, i think this was a very challenging assignment as it combined every aspect from both game engines courses. While i feel it is not my best work, and could be improved upon greatly (use of ECS and state machines with reactive camera and scene navigation) i am, like the first semester, very happy with the performance at the end of it. Seeing something come together mostly autonomously and perform and being able to say i made that makes me very proud. Even if it is not the highest quality i still think it allowed me to show my creativity which is an aspect i believe is always fun to incorporate into coding as it makes it far more enjoyable.

