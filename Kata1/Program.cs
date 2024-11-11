namespace Kata1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player name prompt
            Console.WriteLine("Welcome, brave adventurer! What is your name?");
            Console.Write("> ");
            string playerName = Console.ReadLine(); // Read the player's name

            
            Console.WriteLine($"\nGreetings, {playerName}! Your journey begins now...");

            // Excitement level
            Console.WriteLine("On a scale of 1 to 10, how excited are you to start this quest?");
            Console.Write("> ");
            string excitementInput = Console.ReadLine(); 

            // Parse reaction to excitement level
            if (int.TryParse(excitementInput, out int excitementLevel))
            {
                if (excitementLevel >= 7)
                {
                    Console.WriteLine("\nFantastic! You seem ready to take on any challenge!");
                }
                else
                {
                    Console.WriteLine("\nIt's ok to be nervous, just hold on tight and give it your best.");
                }
            }
            else
            {
                Console.WriteLine("\n I'll just assume you are excited, get ready, your adventure awaits!");
            }

            Console.WriteLine("\nPrepare yourself, the adventure awaits!");
        }
    }
}