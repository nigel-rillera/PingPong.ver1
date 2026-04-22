# PingPong version1

This is my first unity and game ever built! I'll be documenting my journey into learning the basic foundamentals of game development!
A classic 2D Pong clone built using the Unity Engine. This project serves as a foundational exercise in understanding Unity's 2D physics, input handling, and basic game loops.

<img width="978" height="429" alt="image" src="https://github.com/user-attachments/assets/4cc99099-9e2c-4d73-bb29-27870cb59d0c" />

## Current Features

The game currently has the core mechanics of classic Pong up and running:

**Player Paddles:** Two-player local setup with independent paddle controls.
* **Physics-Based Ball:** Bounces dynamically off walls and paddles.
* **Score Zones:** Invisible trigger areas behind the paddles that detect when a point is scored.
* **Scoreboard:** A dynamic UI text element that updates when a player scores.
* **Game Reset Logic:** The ball stops, teleports to the center, and launches in a random direction after a short delay whenever a point is scored.

## Built With
* **Unity** (2D Project Template)
* **C#** (Scripting)
* **TextMeshPro** (UI/Score text)

## How to Play
* **Player 1 (Left):** `W` to move up, `S` to move down.
* **Player 2 (Right):** `Up Arrow` to move up, `Down Arrow` to move down.

## Future Updates May Include:

* [ ] Update Game Manager to handle win/loss states.
* [ ] Add a background design.
* [ ] Fix or update rigid body physics 
* [ ] Add sound effects for bouncing and scoring.
* [ ] Add a main menu and pause screen.
