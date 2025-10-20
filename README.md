# Mission-Demolition
# CS382 Project 2: Mission Demolition

🎯 Game Overview
Objective: Destroy castle structures by launching projectiles from a slingshot

Mechanics: Physics-based projectile motion, castle demolition, level progression

Features: Multiple castle levels, projectile trails, dynamic camera, cloud system for depth perception

🎮 How to Play
Aim: Move mouse over slingshot to activate aiming mode

Pull Back: Click and drag to pull the projectile away from slingshot

Launch: Release mouse button to fire projectile

Demolish: Hit castle blocks and ultimately the green goal area

Progress: Complete each level within limited shots to advance

🔧 Technical Features
Physics Simulation: Rigidbody dynamics with custom physic materials

Camera System: Smooth following with easing and bounds

UI Integration: Level tracking, shot counter, and view switching

Prefab System: Modular castle design for easy level creation

Audio Integration: Immersive sound effects for key interactions

🎯 Level Progression
Multiple castle designs with increasing difficulty

Shot counter tracks player efficiency

Camera view switching between slingshot, castle, and both

Automatic level advancement upon landing the projectile in the goal

✨ Cool Features Added
🎵 Sound Effects
Slingshot stretch: Audio feedback when pulling back the slingshot

Slingshot shoot: Sound when projectile is launched

Block collision: Impact sounds when projectiles hit castle blocks

💥 Destructible Environment
Block breaking system: Castle blocks break if hit with sufficient force

Projectile physics: Blocks respond differently based on impact velocity and angle

🏗️ Key GameObjects
Slingshot: Player's weapon with mouse-driven aiming

Projectile: Physics-based ball with trail rendering

Castle: Destructible structures made of Walls and Slabs

Goal: Target area that must be hit to complete levels

Cloud System: Procedurally generated clouds for visual depth

# Core Scripts
Slingshot.cs: Handles aiming and projectile launching

FollowCam.cs: Dynamic camera that follows projectiles

MissionDemolition.cs: Game state and level management

ProjectileLine.cs: Line rendering for projectile paths

CloudCrafter.cs: Procedural cloud generation