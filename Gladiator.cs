using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorArena
{
    /// <summary>
    /// Base class representing a fighter in the game.
    /// Other character types (like Warrior, Assassin) inherit from this class.
    /// </summary>
    public class Gladiator
    {
        // --- PROPERTIES ---

        /// <summary>
        /// The name of the Gladiator
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Current health points (HP).
        /// </summary>
        public int Health { get; private set; }

        /// <summary>
        /// Minimum damage this fighter can deal.
        /// </summary>
        public int MinDamage { get; private set; }

        /// <summary>
        /// Maximum damage this fighter can deal.
        /// </summary>
        public int MaxDamage { get; private set; }

        /// <summary>
        /// List of items the fighter has collected.
        /// </summary>
        public List<string> Inventory { get; private set; }

        // --- VARIABLES ---

        // Random number generator used for attacks and chances
        protected Random random = new Random();

        // --- CONSTRUCTOR ---

        /// <summary>
        /// Creates a new Gladiator with starting stats.
        /// </summary>
        /// <param name="name">Fighter's name.</param>
        /// <param name="health">Starting HP.</param>
        /// <param name="minDamage">Lowest possible damage.</param>
        /// <param name="maxDamage">Highest possible damage.</param>
        public Gladiator(string name, int health, int minDamage, int maxDamage)
        {
            Name = name;
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;

            this.Inventory = new List<string>();
        }

        // --- METHODS ---

        /// <summary>
        /// Decreases the fighter's health by a specific amount.
        /// Also makes sure health doesn't drop below zero.
        /// </summary>
        /// <param name="damageAmount">Damage to apply.</param>
        public virtual void TakeDamage(int damageAmount)
        {
            this.Health -= damageAmount;

            // Check if health went below zero, fix it if so
            if (this.Health < 0)
            {
                this.Health = 0; 
            }
        }

        /// <summary>
        /// Performs an attack on a target enemy.
        /// Calculates damage and checks for critical hits.
        /// </summary>
        /// <param name="enemy">The enemy to attack.</param>
        public virtual void Attack(Gladiator enemy)
        {
            // 1. Pick a random damage number between Min and Max
            int damage = random.Next(MinDamage, MaxDamage + 1);

            // 2. Roll a die (1-100) to see if it's a critical hit
            int diceRoll = random.Next(1, 101);

            // 15% Chance for Critical Hit
            if (diceRoll <= 15)
            {
                damage = damage * 2; // Double the damage
                enemy.TakeDamage(damage);

                Console.WriteLine($"CRITICAL HIT! {this.Name} demolished {enemy.Name}! ({damage} Damage)");
            }
            else
            {
                //Normal hit
                enemy.TakeDamage(damage);
                Console.WriteLine($"{this.Name} hits {enemy.Name} for {damage} damage.");
            }
        }

        /// <summary>
        /// Checks if the fighter is currently dead.
        /// </summary>
        /// <returns>True if HP is 0, otherwise False.</returns>
        public bool IsDead()
        {
            if (this.Health > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
