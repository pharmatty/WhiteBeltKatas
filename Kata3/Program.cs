namespace Kata3
{
    class Program
    {
        static void Main(string[] args)
        {
            // PlayerLuck variable
            Random random = new Random();
            int playerLuck = random.Next(1, 11);

            Console.WriteLine("You find a mysterious treasure chest! What will you do?");
            Console.WriteLine("1. Open the chest");
            Console.WriteLine("2. Ignore the chest");
            Console.WriteLine("3. Leave the area");
            Console.Write("> ");

            // Player Action
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You try to open the chest...");
                    
                    // Check the playerLuck value
                    if (playerLuck > 7)
                    {
                        Console.WriteLine("Success! The chest contains a rare magic staff!");
                    }
                    else if (playerLuck >= 5)
                    {
                        Console.WriteLine("You find gold inside the chest!");
                    }
                    else
                    {
                        Console.WriteLine("Yikes! The chest was trapped. You're now poisoned.");
                    }
                    break;

                case "2":
                    Console.WriteLine("You decide to walk away from the chest...");
                    break;

                case "3":
                    Console.WriteLine("You leave the dungeon.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }

            // Display the player's luck
            Console.WriteLine($"\nStatus value; your luck was: {playerLuck}");
        }
    }
}
