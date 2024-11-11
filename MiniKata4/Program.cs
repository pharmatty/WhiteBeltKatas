namespace MiniKata4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of enemies to spawn using the for loop
            int numberOfEnemiesForLoop = 5;
            Console.WriteLine("Spawning enemies using a for loop:");

            // For loop to spawn a specific number
            for (int i = 1; i <= numberOfEnemiesForLoop; i++)
            {
                Console.WriteLine($"Enemy #{i} spawned!");
            }

            Console.WriteLine(); 

            // Number of enemies to spawn 
            int numberOfEnemiesWhileLoop = 3;
            int enemyCount = 1;

            Console.WriteLine("Spawning enemies using a while loop:");

            // While loop to spawn enemies
            while (enemyCount <= numberOfEnemiesWhileLoop)
            {
                Console.WriteLine($"Enemy #{enemyCount} spawned!");
                enemyCount++;
            }
        }
    }
}