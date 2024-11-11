namespace MiniKata3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize PlayerLuck
            Random random = new Random();
            int playerLuck = random.Next(1, 11); 
            Console.WriteLine($"Player Luck: {playerLuck}"); 

            // Character attack prompt
            Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
            string playerChoice = Console.ReadLine().Trim().ToLower();

           
            if (playerChoice == "yes")
            {
                Console.WriteLine("Attempting to attack with a sword...");

                
                if (playerLuck > 7)
                {
                    Console.WriteLine("Success! Your attack hits the enemy.");
                }
                else if (playerLuck == 6 || playerLuck == 7)
                {
                    Console.WriteLine("Your attack barely succeeded.");
                }
                else
                {
                    Console.WriteLine("Your sword attack missed!");
                }
            }
            else if (playerChoice == "no")
            {
                Console.WriteLine("You chose to retreat.");
            }
            else
            {
                Console.WriteLine("Please type 'yes' or 'no'.");
            }
        }
    }
}