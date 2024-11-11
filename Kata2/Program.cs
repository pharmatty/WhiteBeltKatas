namespace Kata2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Character attributes
            string name = "Mathias";
            int level = 7;
            float healthPoints = 75.5f;
            double experiencePoints = 1025.75;
            bool hasMagicAbility = true;
            char rank = 'A';

            // Display attributes
            Console.WriteLine($"Character Name: {name}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Health Points: {healthPoints}");
            Console.WriteLine($"Experience Points: {experiencePoints}");
            Console.WriteLine($"Has Magic Ability: {hasMagicAbility}");
            Console.WriteLine($"Rank: {rank}");

            // Next level
            double nextLevelExperience = 1200.0;
            double pointsNeeded = nextLevelExperience - experiencePoints;

            // Points to achieve next level
            Console.WriteLine($"Points needed to reach next level: {pointsNeeded}");
        }
    }
}