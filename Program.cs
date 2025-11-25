namespace GladiatorArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- WELCOME TO THE ARENA ---");

            //Initialization (We use 'fighter' instead of 'g' for clarity)
            Gladiator fighter1 = new Gladiator("Spartacus", 100, 8, 21);
            Gladiator fighter2 = new Gladiator("Crixus", 100, 11, 19);

            Console.WriteLine($"Fighters: {fighter1.Name} vs {fighter2.Name}");
            Console.WriteLine("The Battle Begins...");

            //inital delay
            System.Threading.Thread.Sleep(1500);

            //Game Loop
            while (!fighter1.IsDead()  && !fighter2.IsDead())
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();

                // 1. Fighter 1 Attacks
                fighter1.Attack(fighter2);

                // 2. Zombie Check (If fighter 2 dies, break the loop immediately)
                if (fighter2.IsDead())
                {
                    break;
                }

                // 3. Fighter 2 Attacks (Counter-attack)
                fighter2.Attack(fighter1);

                // Show Stats
                Console.WriteLine($"Stats -> {fighter1.Name}: {fighter1.Health} HP | {fighter2.Name}: {fighter2.Health} HP");

                // Delay between turns (2 seconds)
                System.Threading.Thread.Sleep(2000);
            }

            // End Game Logic
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\n--- BATTLE ENDED ---");
            Console.WriteLine();

            if (fighter1.IsDead())
            {
                Console.WriteLine($"WINNER: {fighter2.Name}");
            }
            else
            {
                Console.WriteLine($"WINNER: {fighter2.Name}");
            }
        }
    }
}
