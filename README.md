# Top-Down Survival Game 🏃‍♂️🔥⚔️

A simple 2D top-down game built in **Unity 2022+** as a school project to demonstrate proper use of:

- **Tags**  
- **Colliders**  
- **Rigidbodies**  
- **Tilemaps**  
- **Physics 2D**

No external packages or assets used — only Unity built-in features.

---

### 🎮 Gameplay
- Move with **WASD** or **Arrow Keys**
- Avoid the wandering **Knight** (Enemy)
- Don't step on the **Bonfire** 🔥
- If you touch either → **You die and the level restarts**

The knight roams randomly across the map and bounces off houses using physics.

---

### 🖼️ Screenshot
![Game Screenshot](screenshot.png)
*(Replace with your actual screenshot)*

---

### 🛠️ How It Works (For Your Teacher)

| Feature              | Implementation                                  |
|----------------------|--------------------------------------------------|
| **Player Movement**  | `Rigidbody2D.velocity` + normalized input       |
| **Enemy AI**         | Random direction changes every ~2 seconds       |
| **Death System**     | `OnCollisionEnter2D` (Knight) + `OnTriggerEnter2D` (Bonfire) |
| **Collision**        | BoxCollider2D on all objects                    |
| **No Gravity**       | Gravity Scale = 0 on Player & Knight            |
| **Static Ground**    | Tilemap with **Tilemap Collider 2D** + **Static Rigidbody2D** on Grid |
| **Object Detection** | Using **Tags**: `"Player"`, `"Enemy"`, `"Bonfire"` |

---

### 🚀 How to Run
1. Clone the repo
   ```bash
   git clone https://github.com/YOUR_USERNAME/TopDownSurvivalGame.git
