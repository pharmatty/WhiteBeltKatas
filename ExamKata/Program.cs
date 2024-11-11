namespace ExamKata
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player/Enemy Stats
            int playerHealth = 70;
            int playerAttack = 15;
            int playerHeal = 10;
            int enemyHealth = 60;
            int enemyAttack = 10;

            // Game Session Loop
            while (playerHealth > 0 && enemyHealth > 0)
            {
                // Health display
                Console.Clear();
                Console.WriteLine($"Hero's Health: {playerHealth}");
                Console.WriteLine($"Goblin's Health: {enemyHealth}");

                // Action Prompt
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                string playerChoice = Console.ReadLine();

                // Player action value 1/2
                if (playerChoice == "1")
                {
                    // Player Attack
                    enemyHealth -= playerAttack;
                    Console.WriteLine($"\nHero attacks Goblin with a sword!");
                    Console.WriteLine($"Goblin lunges at the hero with a club and causes {playerAttack} damage.");
                }
                else if (playerChoice == "2")
                {
                    // Player Heal 
                    playerHealth += playerHeal;
                    Console.WriteLine($"\nHero heals themselves for {playerHeal} health.");
                }
                else
                {
                    Console.WriteLine("\nPlease choose action 1 or 2.");
                    continue; 
                }

                // Enemy Defeat check
                if (enemyHealth <= 0)
                {
                    Console.WriteLine("\nCongratulations! You have defeated the Goblin!");
                    break;
                }

                // Enemy attacks the player automatically
                playerHealth -= enemyAttack;
                Console.WriteLine($"\nGoblin attacks Hero!");
                Console.WriteLine($"Hero takes {enemyAttack} damage.");

                // Check if the player is defeated
                if (playerHealth <= 0)
                {
                    Console.WriteLine("\nGame Over! Hero has been defeated.");
                    break;
                }

                // Pause for a moment before the next round
                Console.WriteLine("\nPress Enter to continue to the next round...");
                Console.ReadLine();
            }
        }
    }
}
