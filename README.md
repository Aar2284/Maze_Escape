# 🎮 Unity Maze Ball Game

> A fully interactive 3D maze adventure built using Unity where the player controls a rolling sphere through a challenging maze, collects coins, avoids obstacles, opens the final exit door, and reaches the game-over ending screen.

---

# 📌 Project Overview

This project is a 3D maze-based game developed in Unity using physics-based movement and interactive gameplay mechanics.

The player controls a rolling sphere ball through a large maze environment using keyboard controls. Throughout the maze, the player:

* 🪙 Collects coins to gain points
* ⚠️ Avoids obstacles that reduce score
* 🚪 Reach the final exit door
* 🏁 Reaches the ending trigger to complete the game
* 🎵 Experiences immersive background music
* 🎥 Plays from a smooth third-person camera perspective

The game combines:

* Physics-based gameplay
* UI systems
* Collision systems
* Trigger systems
* Animation systems
* Audio systems
* Camera follow mechanics

making it an excellent beginner-to-intermediate Unity project.

---

# 🧩 Features

## 🎮 Player System

* Smooth rolling sphere movement
* Rigidbody-based physics controls
* WASD movement controls
* Third-person style camera following
* Large-scale maze navigation

---

## 🎥 Dynamic Camera System

* Camera follows player smoothly
* Third-person perspective gameplay
* Adjustable camera offsets
* Real-time tracking movement
* Large maze visibility support

---

## 🪙 Coin Collection System

* Interactive collectible coins
* Coins disappear after collection
* Score increases on collection
* Trigger-based detection system

---

## ⚠️ Obstacle System

* Interactive obstacle collisions
* Score deduction system
* Physics-based collision handling
* Real-time UI updates

---

## 📊 Score UI System

* Live score tracking
* Real-time score updates
* TextMeshPro UI integration
* Screen-space UI display

---

## 🚪 Exit Door System

* Animated exit door
* Keyboard interaction system
* Trigger-based player detection
* Collider disabling after opening

---

## 🏁 Game Over System

* Final trigger zone detection
* Fullscreen game over panel
* Game freeze at completion
* UI-based ending screen

---

## 🎵 Audio System

* Background music integration
* Looping music support
* Immersive gameplay experience

---

# 🕹️ Controls

| Key   | Action                |
| ----- | --------------------- |
| ⬆️ W  | Move Forward          |
| ⬇️ S  | Move Backward         |
| ⬅️ A  | Move Left             |
| ➡️ D  | Move Right            |
| 🅾️ O | Start Intro Animation |
| 🅲 C  | Open Exit Door        |

---

# 🧱 Technologies Used

| Technology           | Purpose          |
| -------------------- | ---------------- |
| 🎮 Unity             | Game Engine      |
| 🧠 C#                | Scripting        |
| ⚙️ Rigidbody Physics | Ball Movement    |
| 🎨 TextMeshPro       | UI System        |
| 🎥 Animator System   | Door Animation   |
| 🔊 Audio Source      | Background Music |

---

# 🏗️ Game Architecture

The project follows a modular structure where each gameplay system is separated into different components.

## Main Systems

### 🎮 Player System

Handles:

* Movement
* Physics
* Collisions
* Camera-relative controls

---

### 🎥 Camera System

Handles:

* Smooth following
* Dynamic positioning
* Third-person perspective

---

### 📊 Game Manager

Handles:

* Score management
* UI updates
* Shared gameplay systems

---

### 🪙 Coin System

Handles:

* Trigger detection
* Point rewards
* Object destruction

---

### ⚠️ Obstacle System

Handles:

* Collision detection
* Score penalties

---

### 🚪 Door System

Handles:

* Animation triggering
* Door interaction
* Collider disabling

---

### 🏁 End Game System

Handles:

* Trigger detection
* Game over panel activation
* Gameplay freeze

---

# 🌍 Game Flow

## 🎬 Intro Sequence

The game begins with the player positioned outside the maze.

When the player presses:

```text
O Key
```

an intro animation begins and the player enters the maze environment.

---

## 🌀 Maze Exploration

The player explores the maze using:

* WASD controls
* Camera-follow navigation
* Physics-based rolling movement

The player searches for:

* 🪙 Coins
* 🚪 Exit Door

while avoiding:

* ⚠️ Obstacles

---

## 🪙 Coin Collection

When the player touches a coin:

* Coin disappears
* Score increases
* UI updates instantly

This encourages exploration and reward-based gameplay.

---

## ⚠️ Obstacle Collision

When the player collides with an obstacle:

* Score decreases
* UI updates immediately

This introduces challenge and risk during maze navigation.

---

## 🚪 Exit Door Interaction

At the end of the maze:

* The player approaches the exit door
* Presses:

```text
C Key
```

* Door animation plays
* Door opens
* Player proceeds forward

---

## 🏁 Game Completion

Once the player crosses the final trigger:

* Game over screen appears
* Gameplay freezes
* Maze completion is achieved

---

# 🧠 Core Concepts Learned

This project demonstrates several important Unity development concepts.

---

## 🎮 Rigidbody Physics

The player movement system uses Rigidbody physics rather than direct transform movement.

Benefits:

* Smooth rolling motion
* Natural physics behavior
* Realistic interactions
* Collision support

---

## ⚡ Collision & Trigger Systems

The project uses:

* OnCollisionEnter()
* OnTriggerEnter()

for gameplay interactions.

This teaches:

* Trigger colliders
* Physics colliders
* Interaction systems
* Detection systems

---

## 🎥 Camera Follow Mechanics

The third-person camera system dynamically follows the player.

This introduces:

* Camera offsets
* Smooth movement
* Player tracking
* LateUpdate usage

---

## 📊 UI Systems

The project uses TextMeshPro for:

* Score display
* Game over panels
* Real-time UI updates

---

## 🎞️ Animation System

The exit door uses Unity Animator components.

This demonstrates:

* Animation clips
* Animator controllers
* Trigger parameters
* Interactive animation systems

---

## 🔊 Audio Integration

The project supports:

* Background music
* Audio Source components
* Looping audio playback

---

# 🗂️ Project Structure

```text
Assets
│
├── Scripts
│   ├── BallMovement
│   ├── CameraFollow
│   ├── Coin
│   ├── ObstacleHit
│   ├── GameManager
│   ├── DoorController
│   └── EndGame
│
├── Audio
│
├── Animations
│
├── Materials
│
├── Prefabs
│
└── Scenes
```

---

# 🧱 Scene Hierarchy Example

```text
Main Camera
Directional Light
Ground
Walls
Player
Coins
Obstacles
ExitDoor
GameManager
Canvas
EndTrigger
BackgroundMusic
```

---

# 📸 Screenshots Section

# 🎬 Scene View

> Add Scene View Screenshot Here

![Scene View](Screenshots/scene-view.png)

---

# 🎮 Gameplay View

> Add Gameplay Screenshot Here

```text
[ INSERT GAME VIEW SCREENSHOT ]
```

---

# 🪙 Coin Collection System

> Add Coin Collection Screenshot Here

```text
[ INSERT COIN COLLECTION SCREENSHOT ]
```

---

# ⚠️ Obstacle Interaction

> Add Obstacle Collision Screenshot Here

```text
[ INSERT OBSTACLE SCREENSHOT ]
```

---

# 🚪 Door Opening Animation

> Add Door Animation Screenshot Here

```text
[ INSERT DOOR OPENING SCREENSHOT ]
```

---

# 🏁 Game Over Panel

> Add Game Over Screenshot Here

```text
[ INSERT GAME OVER PANEL SCREENSHOT ]
```

---

# 🚀 Future Improvements

The project can be expanded further with advanced gameplay systems.

---

## 🌟 Possible Enhancements

### 🕒 Timer System

Add:

* Countdown timer
* Speedrun mechanics
* Time-based scoring

---

### ❤️ Health System

Introduce:

* Player health
* Damage mechanics
* Respawn system

---

### 🎯 Multiple Levels

Expand gameplay with:

* Different maze layouts
* Increasing difficulty
* Environment themes

---

### 🤖 Enemy AI

Add:

* Maze enemies
* Patrol systems
* Chase mechanics

---

### 🔊 Advanced Audio

Add:

* Coin sound effects
* Obstacle hit sounds
* Door sounds
* Ambient music

---

### ✨ Visual Effects

Improve visuals with:

* Particle effects
* Lighting systems
* Bloom effects
* Post processing

---

### 💾 Save System

Implement:

* Progress saving
* High scores
* Level unlocks

---

### 🏆 Leaderboard System

Add:

* Online scores
* Competitive gameplay
* Global ranking

---

# 📚 Learning Outcomes

By building this project, developers learn:

* Unity scene management
* Rigidbody physics
* Camera systems
* Trigger systems
* Collision systems
* Animator systems
* UI systems
* Audio systems
* Object interaction
* Game architecture
* Gameplay design

---

# 🧪 Testing Checklist

## ✅ Gameplay

* [ ] Player movement works
* [ ] Camera follows correctly
* [ ] Coin collection works
* [ ] Obstacles reduce score
* [ ] Score UI updates correctly
* [ ] Door opens successfully
* [ ] End trigger activates
* [ ] Game over panel appears
* [ ] Background music plays

---

# 🛠️ Installation & Setup

## Requirements

* Unity Hub
* Unity Editor
* TextMeshPro Package

---

## Steps

1. Clone or download project
2. Open project in Unity
3. Open main scene
4. Press Play
5. Enjoy the game 🎮

---

# 🎯 Game Objective

Navigate through the maze, collect coins, avoid obstacles, open the final exit door, and complete the maze with the highest score possible.

---

# 🙌 Credits

## 👨‍💻 Developed With

* Unity Engine
* C#
* TextMeshPro

---

# ⭐ Final Notes

This project serves as a strong beginner-friendly 3D Unity game that demonstrates the foundations of gameplay programming, UI systems, camera mechanics, physics interactions, animations, and game architecture.

It can be used as:

* A portfolio project
* A learning project
* A foundation for larger games
* A college/project submission
* A Unity practice project

---

# 🎮 Thank You For Playing
