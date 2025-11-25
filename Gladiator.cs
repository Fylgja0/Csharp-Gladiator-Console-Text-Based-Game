using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorArena
{
    public class Gladiator
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }

        public Gladiator(string name, int health, int minDamage, int maxDamage)
        {
            Name = name;
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        Random random = new Random();

        public void TakeDamage(int damageAmount)
        {
            this.Health -= damageAmount;
            if (this.Health < 0)
            {
                this.Health = 0; 
            }
        }

        public void Attack(Gladiator enemy)
        {
            int damage = random.Next(MinDamage, MaxDamage + 1);

            int diceRoll = random.Next(1, 101);

            if (diceRoll <= 20)
            {
                damage = damage * 2;
                enemy.TakeDamage(damage);

                Console.WriteLine($"CRITICAL HIT! {this.Name} demolished {enemy.Name}! ({damage} Damage)");
            }
            else
            {
                enemy.TakeDamage(damage);
                Console.WriteLine($"{this.Name} hits {enemy.Name} for {damage} damage.");
            }
        }

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
