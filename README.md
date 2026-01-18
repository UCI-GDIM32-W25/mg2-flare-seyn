[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
For MG2, my original plan from the break-down activity was to recreate the core loop of an endless runner–style game. The player would stay mostly centered on the screen while gameplay elements such as coins move from right to left. The player’s main interactions would be jumping to avoid missing collectibles and earning points by colliding with coins.


This plan directly connects to how I structured my Unity scene and scripts. In the Scene Hierarchy, I separated responsibilities into distinct GameObjects, including player, ground, Coin Spawner, and GameManager. Each object corresponds to a specific system described in my planning stage.


The Player GameObject uses a Rigidbody2D and CapsuleCollider2D for physics, and the jump mechanic is implemented in the Player script. The jump logic uses a ground-check system to prevent mid-air jumping. Specifically, the Physics2D.OverlapCircle() method checks whether the player is touching the Ground layer using a child Transform called groundCheck. This directly matches my original plan to limit jumping to when the player is grounded.


Coins are implemented as a reusable Coin prefab, which contains a CircleCollider2D set as a trigger and a ScrollLeft script. The scrolling behavior moves coins leftward every frame using transform.Translate() so the world appears to move while the player remains mostly stationary. When coins move off screen, the DestroyOffscreen script removes them to avoid clutter.


The Coin Spawner GameObject follows my planned spawning system by instantiating coin prefabs at a fixed X position on the right side of the screen. The CoinSpawner script uses Instantiate() along with a timer to repeatedly generate coins at runtime rather than placing them manually in the scene.


Point tracking is handled by a centralized GameManager object. When the player collides with a coin, the OnTriggerEnter2D() method in the Coin script calls a public method in GameManager to increase the score. The updated score is then displayed through a UI Text object named PointsText, connecting gameplay events to visual feedback.


My plan changed slightly during development. Originally, I expected to place multiple coins manually, but after reviewing the professor’s example and working through implementation, I realized that using prefabs and a spawner created a cleaner and more scalable design. This adjustment made the game closer to a true endless runner and reduced repeated scene setup.


Overall, the final implementation closely follows my planning document while improving structure through prefabs, script separation, and runtime spawning. The planning stage helped guide the overall architecture, while coding decisions refined how the systems interacted in practice.


## Open-Source Assets


- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
