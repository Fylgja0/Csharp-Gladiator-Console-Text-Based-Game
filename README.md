# ⚔️ Gladiator Arena - Interactive RPG

An interactive, turn-based console RPG game built with **C#** and **.NET**. Unlike simple simulations, this project puts **YOU** in the arena. You must choose your actions wisely against a smart AI opponent to survive and claim the loot.

## 🎮 Game Features & Mechanics

### 🕹️ Interactive Combat Loop
- **Player Control:** You are in command of **Spartacus** (Warrior).
  - **1) ATTACK:** Strike the enemy using your weapon.
  - **2) HEAL:** Take a risk to restore **10-30 HP**.
- **Dynamic Turn System:** The game pauses for your input and simulates enemy thinking time for a realistic flow.

### 🤖 Smart Enemy AI
- The enemy isn't just random.
- **Decision Making:** If the enemy's health is low, there is a chance it will choose to **Heal** instead of attacking.
- **Randomized Spawning:** Every time you play, you face a different Assassin (e.g., *Crixus, Gannicus, Verus*) selected from a name pool.

### 🛡️ Class System (Inheritance & Polymorphism)
- **Warrior (Player):** Inherits from Gladiator. Has a unique `ArmorBonus` that reduces incoming damage by a fixed amount every turn.
- **Assassin (Enemy):** Inherits from Gladiator. Has a `CritChance` property. Rolls a die every turn for a chance to deal **Double Damage**.

### 💰 Loot & Inventory
- **Reward System:** The winner receives a random item (e.g., *Golden Cup*, *Health Potion*).
- **Collections:** Items are stored in a dynamic `List<string>` inventory structure.

## 📸 Example Gameplay Output

```text
--- WELCOME TO THE ARENA ---
Fighters: Spartacus vs Gannicus
The Battle Begins...

-----------------------------------

[PLAYER TURN] Spartacus (HP: 100/100)
CHOOSE ACTION
1) ATTACK
2) HEAL
Choice: 1

Spartacus hits Gannicus for 16 damage.

[ENEMY TURN] Gannicus is thinking...

Gannicus attacks Spartacus swiftly using daggers. (18 Damage)
Spartacus (Warrior) uses armor! Blocks 4 damage. Taken: 14

-----------------------------------

Stats -> Spartacus: 86 HP | Gannicus: 84 HP

-----------------------------------

[PLAYER TURN] Spartacus (HP: 86/100)
CHOOSE ACTION
1) ATTACK
2) HEAL
Choice: 2

Spartacus heals for 22 HP. (Current HP: 100)

... (Battle Continues) ...

-----------------------------------

--- BATTLE ENDED ---

WINNER: Spartacus!
Spartacus loots a Mysterious Key from the arena!

--- WINNER'S INVENTORY ---
- Mysterious Key
