namespace GladiatorArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- WELCOME TO THE ARENA ---");

            // --- RANDOM ENEMY SETUP ---

            // List of possible names for the enemy
            string[] enemyNames = { "Crixus", "Gannicus", "Oenomaus", "Verus", "Priscus", "Tetraites" };

            // 2. Initialize the Random object for selection logic.
            Random rng = new Random();

            // 3. Select a random index within the bounds of the array (0 to Length).
            int index = rng.Next(0, enemyNames.Length);
            string randomName = enemyNames[index];

            // --- CREATE FIGHTERS ---

            // Create the Player (Warrior class).
            // Stats: Name, Health, MinDamage, MaxDamage, Armor
            Warrior fighter1 = new Warrior("Spartacus", 100, 10, 20, 4);

            // Create the Enemy (Assassin class) with the random name we picked.
            // Assassin has critical chance instead of armor.
            Assassin fighter2 = new Assassin(randomName, 80, 15, 25, 35);

            Console.WriteLine($"Fighters: {fighter1.Name} vs {fighter2.Name}");
            Console.WriteLine("The Battle Begins...");

            // Wait for 1.5 seconds before starting
            System.Threading.Thread.Sleep(1500);

            // --- GAME LOOP ---

            // Loop runs while both fighters are alive
            while (!fighter1.IsDead()  && !fighter2.IsDead())
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();

                // 1. Fighter 1 Attacks
                fighter1.Attack(fighter2);

                // 2. Zombie Check
                // If fighter 2 dies, break the loop immediately
                if (fighter2.IsDead())
                {
                    break;
                }

                // 3. Fighter 2 Attacks (Counter-attack) if still alive
                fighter2.Attack(fighter1);

                // Show current health for both
                Console.WriteLine($"Stats -> {fighter1.Name}: {fighter1.Health} HP | {fighter2.Name}: {fighter2.Health} HP");

                // Wait 2 seconds between turns
                System.Threading.Thread.Sleep(2000);
            }

            // --- END GAME ---

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\n--- BATTLE ENDED ---");
            Console.WriteLine();

            // List of items that can drop
            string[] lootTable = { "Gold Coin", "Health Potion", "Broken Dagger", "Silver Ring", "Mysterious Key" };

            Gladiator winner;

            // Check who died to find the winner
            if (fighter1.IsDead())
            {
                winner = fighter2;
            }
            else
            {
                winner = fighter1;
            }

            Console.WriteLine($"WINNER: {winner.Name}");

            // Pick a random item for the winner
            rng = new Random();
            index = rng.Next(0, lootTable.Length);
            string prize = lootTable[index];

            // Add item to the winner's bag (inventory)
            winner.Inventory.Add(prize);

            Console.WriteLine($"{winner.Name} loots a {prize} from the arena!");

            // Show what the winner has now
            Console.WriteLine("\n--- WINNER'S INVENTORY ---");
            foreach (string item in winner.Inventory)
            {
                Console.WriteLine($"- {item}");
            }

            // Wait for user key press to close
            Console.ReadKey();
        }
    }
}
