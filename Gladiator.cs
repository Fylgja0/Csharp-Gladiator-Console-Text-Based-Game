using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorArena
{
    /// <summary>
    /// Represents a Gladiator character with properties for health, damage, and combat actions.
    /// </summary>
    public class Gladiator
    {
        // PROPERTIES

        /// <summary>
        /// The name of the Gladiator
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Current health points of the Gladiator.
        /// </summary>
        public int Health { get; private set; }

        /// <summary>
        /// Minimum possible damage per hit.
        /// </summary>
        public int MinDamage { get; private set; }

        /// <summary>
        /// Maximum possible damage per hit.
        /// </summary>
        public int MaxDamage { get; private set; }

        // VARIABLES

        // Random number generator for combat mechanics
        Random random = new Random();

        // CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the Gladiator class.
        /// </summary>
        /// <param name="name">The name of the fighter.</param>
        /// <param name="health">Starting health points.</param>
        /// <param name="minDamage">Minimum damage range.</param>
        /// <param name="maxDamage">Maximum damage range</param>
        public Gladiator(string name, int health, int minDamage, int maxDamage)
        {
            Name = name;
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        // METHODS

        /// <summary>
        /// Reduces the Gladiator's health by the specified amount.
        /// Prevents health from dropping below zero.
        /// </summary>
        /// <param name="damageAmount">The amount of damage taken.</param>
        public void TakeDamage(int damageAmount)
        {
            this.Health -= damageAmount;

            // Health validation: Health cannot be negative
            if (this.Health < 0)
            {
                this.Health = 0; 
            }
        }

        /// <summary>
        /// Calculates damage and attacks the target enemy.
        /// Includes a 15% chance for a Critical Hit (2x Damage).
        /// </summary>
        /// <param name="enemy">The target Gladiator to attack.</param>
        public void Attack(Gladiator enemy)
        {
            // 1. Calculate base damage
            int damage = random.Next(MinDamage, MaxDamage + 1);

            // 2. Roll for critical hit chance (1-100)
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
        /// Checks if the Gladiator is dead.
        /// </summary>
        /// <returns>True if health is 0 or less; otherwise, false.</returns>
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
