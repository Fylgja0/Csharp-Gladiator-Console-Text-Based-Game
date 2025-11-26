using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorArena
{
    /// <summary>
    /// A specialized Fighter class representing a Warrior.
    /// Inherits from Gladiator and adds defense/armor logic.
    /// </summary>
    public class Warrior : Gladiator
    {
        // --- PROPERTIES ---

        /// <summary>
        /// The amount of damage this warrior blocks every time they get hit.
        /// </summary>
        public int ArmorBonus { get; private set; }

        // --- CONSTRUCTOR ---

        /// <summary>
        /// Creates a new Warrior instance.
        /// </summary>
        /// <param name="name">Warrior's name.</param>
        /// <param name="health">Starting HP.</param>
        /// <param name="minDamage">Lowest damage.</param>
        /// <param name="maxDamage">Highest damage.</param>
        /// <param name="armorBonus">Amount of damage to block.</param>
        public Warrior(string name, int health, int minDamage, int maxDamage, int armorBonus)
            : base(name, health, minDamage, maxDamage) // Pass basic stats to the parent (Gladiator) class
        {
            this.ArmorBonus = armorBonus;
        }

        // --- METHODS ---

        /// <summary>
        /// Overrides the default damage logic to include Armor.
        /// Incoming damage is reduced by the ArmorBonus.
        /// </summary>
        /// <param name="damageAmount">Original damage amount.</param>
        public override void TakeDamage(int damageAmount)
        {
            // Calculate damage after armor blocks some of it
            int reducedDamage = damageAmount - ArmorBonus;

            // Damage cannot be negative (healing from an attack is not allowed)
            if (reducedDamage < 0) reducedDamage = 0;

            Console.WriteLine($"{Name} (Warrior) uses armor! Blocks {ArmorBonus} damage. Taken: {reducedDamage}");

            // Apply the final reduced damage using the base class logic
            base.TakeDamage(reducedDamage);
        }
    }
}
