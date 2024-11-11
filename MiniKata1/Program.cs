namespace MiniKata1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declared variables
            string characterName = "Mathias";
            int healthPoints = 100;         
            float attackPower = 15.5f;      
            bool isParalyzed = true;        
            double currencyAmount = 24.75;  

            
            Console.WriteLine($"Character Name: {characterName}");
            Console.WriteLine($"Health Points: {healthPoints}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Is Paralyzed: {isParalyzed}");
            Console.WriteLine($"Gold Coins: {currencyAmount}");
        }
    }
}