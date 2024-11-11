namespace Kata4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the number of waves and enemies per wave
            int totalWaves = 3;
            int enemiesPerWave = 4;

            // Simulate waves
            for (int wave = 1; wave <= totalWaves; wave++)
            {
                Console.WriteLine($"\nWave {wave} is starting!");

                
                for (int enemy = 1; enemy <= enemiesPerWave; enemy++)
                {
                    Console.WriteLine($"  Enemy #{enemy} has spawned.");
                }

                Console.WriteLine($"Wave {wave} completed. Preparing for the next wave...");

                // Spawn delay
                Thread.Sleep(3000);
            }

            // Display victory message after all waves are completed
            Console.WriteLine("\nAll the waves are defeated! Victory is yours!");
        }
    }
}