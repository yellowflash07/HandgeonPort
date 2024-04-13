Game Componenets Sprint 2 

- This project was done as a group, by Ershad(1127007),Max Sherwin(1128059), Keerthivasan Kalaivanan(1190826)
	
-----------------------------------------------------------------------------------------------------------------------------
Build Process
1. Just open the project in Unity. Version used is 2021.3.23f1
-----------------------------------------------------------------------------------------------------------------------------

About this project 

Things which have been implement in this project
Sprint #1 (In Panda Engine)
    - Entity can be read by JSON
    - 3rd Person Player Controls
    - Movement for the entitiy
    - UML diagram for the base game structure
    - Factory pattern used for creating player
Sprint #2(In Panda Engine)

    - Added jump functionality.
    - Player is controlled by velocity, instead of direct updates to draw position.
    - Player collision implemented.
    - Lossless, lossy, optimized compressions for all pngs on building.
    - Used pngquant, optipng, PVRTex tool.
    - Already compressed pngs will not be compressed again.
    - Core game mechanic of platforming implemented.
Sprint #3(In Panda Engine)
    - SQLLite has been implemented(Create, Insert, Update and Select commands are used).
    - Functions for Set and Get are implemented(Implementation can be viewed in SQLManager.h and SQLManager.cpp).
    - Created two tables "PlayerJumpLog" and "PlayerPositionLog" using SQLLite. 
    - Everytime the player jumps, the jump count is incremented in the table and displayed to console. 
    - Also the current position is updated to the "PlayerPositionLog" table and displayed from it.
    - FMOD has been implemented
    - Lua Has been implemented
    - FMOD audio and events called through Lua
    - There are Two audio events as of now  which is , Walk and Jump and The background music 
Sprint #4 (In Unity Engine)
    - Game implemented in Unity
    - Puzzle mechanic implemented (Move the box to the trigger point to open the door)
    - Hand has animation, watch it "crawl" as you move
    - Physics implemented, all objects are moved using rigidbodies
    - Audio implemented, there is a background audio, one sfx for walking and one sfx when pushing the box. 
    - NOTE: There is a small delay in the looping of the audio sfx of while pushing box because the the clip is too long.
    
-----------------------------------------------------------------------------------------------------------------------------
	
Controls for the project

WASD to move the hand
Space to jump
Mouse to rotate the camera

 - Published in Git (https://github.com/yellowflash07/HandgeonPort)