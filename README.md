# ⚔️ Gladiator Arena Console Game

A turn-based RPG battle simulation built with **C#** and **.NET**. This project demonstrates core Object-Oriented Programming (OOP) principles, game logic implementation, and clean code practices.

## 🎮 Game Mechanics
- **Turn-Based Combat:** Gladiators attack each other in turns.
- **Randomized Damage:** Damage calculation involves RNG (Random Number Generation) for dynamic gameplay.
- **Critical Hit System:** There is a **15% chance** to deal double damage ("Critical Hit").
- **Health Management:** Prevents health from dropping below zero using logic checks.

## 🚀 Key Concepts & Technologies
This project was created to practice and demonstrate the following concepts:
- **C# / .NET Core**
- **OOP Principles:**
  - **Encapsulation:** Using `private set` to protect data integrity (e.g., Health).
  - **Classes & Objects:** Modular design separating the `Gladiator` class from the `Program` logic.
- **Algorithmic Logic:**
  - Game Loop (`while` state management).
  - Conditional Logic (`if-else` for critical hits and death checks).
  - "Zombie Check" (Breaking the loop immediately when a fighter dies).

## 📂 Project Structure
- **`Program.cs`**: Handles the game loop, UI rendering, and flow control.
- **`Gladiator.cs`**: Defines the Gladiator object properties, constructor, and combat methods (Attack, TakeDamage).

## 📸 Example Output
```text
--- WELCOME TO THE ARENA! ---
Fighters: Spartacus vs Crixus
The Battle Begins...

-----------------------------------

Spartacus hits Crixus for 14 damage.
Crixus hits Spartacus for 12 damage.
Stats -> Spartacus: 88 HP | Crixus: 86 HP

-----------------------------------

CRITICAL HIT! Spartacus demolished Crixus! (32 Damage)
Stats -> Spartacus: 88 HP | Crixus: 54 HP

...

--- BATTLE ENDED ---
WINNER: Spartacus!
