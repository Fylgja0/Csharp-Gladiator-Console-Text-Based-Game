# ⚔️ Gladiator Arena Console Game

A turn-based RPG battle simulation built with **C#** and **.NET**. This project demonstrates core Object-Oriented Programming (OOP) principles, game logic implementation, and clean code practices.

## 🎮 Game Mechanics
- **Class System (Inheritance):**
  - **Warrior:** Has `ArmorBonus` property. Blocks incoming damage by a fixed amount.
  - **Assassin:** Has `CritChance` property. Deals double damage based on probability logic.
- **Dynamic Enemy Spawning:** Enemies are randomly generated from a name pool with varying stats.
- **Loot System:** Winners are rewarded with randomized items stored in a `List<string>` inventory.
- **Turn-Based Combat:** Gladiators attack each other in turns with Polymorphic behavior.

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
--- WELCOME TO THE ARENA ---
Fighters: Spartacus vs Gannicus
The Battle Begins...

-----------------------------------

Spartacus hits Gannicus for 12 damage.
ASSASSIN STRIKE! Gannicus found a weak spot on Spartacus! (34 Damage)
Spartacus (Warrior) uses armor! Blocks 4 damage. Taken: 30
Stats -> Spartacus: 70 HP | Gannicus: 68 HP

-----------------------------------

Spartacus hits Gannicus for 15 damage.
Gannicus attacks Spartacus swiftly using daggers. (14 Damage)
Spartacus (Warrior) uses armor! Blocks 4 damage. Taken: 10
Stats -> Spartacus: 60 HP | Gannicus: 53 HP

... (Battle continues) ...

-----------------------------------

--- BATTLE ENDED ---
WINNER: Spartacus!
Spartacus loots a Mysterious Key from the arena!

--- WINNER'S INVENTORY ---
- Mysterious Key
