using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorArena
{
    /// <summary>
    /// A specialized Fighter class representing an Assassin.
    /// Inherits from Gladiator and focuses on high critical hit chances.
    /// </summary>
    public class Assassin : Gladiator
    {
        // --- PROPETRIES ---

        /// <summary>
        /// The percentage chance (0-100) to land a critical hit.
        /// </summary>
        public int CritChance { get; private set; }

        // --- CONSTRUCTOR ---


        /// <summary>
        /// Creates a new Assassin instance.
        /// </summary>
        /// <param name="name">Assassin's name.</param>
        /// <param name="health">Starting HP.</param>
        /// <param name="minDamage">Lowest damage.</param>
        /// <param name="maxDamage">Highest damage.</param>
        /// <param name="critChance">Chance to deal double damage.</param>
        public Assassin(string name, int health, int minDamage, int maxDamage, int critChance)
            :base(name, health, minDamage, maxDamage) // Pass basic stats to the parent (Gladiator) class
        {
            this.CritChance = critChance;
        }

        // --- METHODS ---

        /// <summary>
        /// Overrides the default attack logic to use the Assassin's custom CritChance.
        /// </summary>
        /// <param name="enemy">The target enemy.</param>
        public override void Attack(Gladiator enemy)
        {
            // 1. Calculate base damage
            int damage = random.Next(MinDamage, MaxDamage + 1);

            // 2. Roll a die (1-100)
            int diceRoll = random.Next(1, 101);

            // Check if the roll is within the Assassin's critical range
            if (diceRoll <= CritChance)
            {
                // Double the damage for a critical hit
                damage = damage * 2;

                Console.WriteLine($"ASSASSIN STRIKE! {Name} found a weak spot on {enemy.Name}! ({damage} Damage)");

                enemy.TakeDamage(damage);
            }
            else
            {
                // Normal hit (failed critical roll)
                Console.WriteLine($"{Name} attacks {enemy.Name} switftly using daggers. ({damage} Damage)");

                enemy.TakeDamage(damage);
            }
        }
    }
}
