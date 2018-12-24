# Project Ara
This is a prototype for complete hardware/software system to help the blind and low vision people navigate new environment using spatial sound. The hypothesis is that after some time of using the system, sensory substitution will occur in the brain will be able to automatically envision the image (https://en.wikipedia.org/wiki/Sensory_substitution). See it in action:

https://www.youtube.com/watch?v=wnokEU0vZD8&feature=youtu.be

## Product vision
The complete vison for the product includes a combination of hardware and software. Specifically:
1. Scanning hardware: A 3D scanning hardware (e.g. hololens or something lighter), or RGB camera + RGB-To-3D method (e.g., machine learning) 
2. Headphones: Headphones with variable noise cancellation (e.g. surface headphones), or bone conduction headphones (to allow user to hear the outside world at the same time)
3. Spatial audio generator software: Unity spatial audio

## Concept of spatial audio generation
Use raycasts from the user head at multiple angels. if the raycast hit something, generate audio in the location (i.e. spatial audio) of the contact with volume (or another parameter) depending on the distance.

## Objective of prototype
Can the user navigate the maze without hitting the wall?

## Plan for software improvments/testing
Create an endless runner game or a maze that everybody can play on thier phones. This game will be used as a test bed for ideas (e.g., what kind of sound work best and at what levels...)

## How to compile
The code is written in Unity3D.

## Where is the project now
For the time being, I am focused on finishing off my PhD. I will get back to it in a couple of months.
  
## License
The project is licensed under the GPL license. 
