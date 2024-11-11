namespace MiniKata2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables
            string characterName = "Mathias";
            int healthPoints = 100;
            float attackPower = 30.75f;
            float experiencePoints = 250.55f;
            bool isParalyzed = false;
            double currencyAmount = 50.75;

            // Value check
            Console.WriteLine($"Character Name: {characterName}");
            Console.WriteLine($"Health Points: {healthPoints}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Experience Points: {experiencePoints}");
            Console.WriteLine($"Is Paralyzed: {isParalyzed}");
            Console.WriteLine($"Currency Amount: {currencyAmount}\n");

            // Implicit Conversion
            double healthAsDouble = healthPoints;  
            Console.WriteLine($"Health as double (implicit conversion): {healthAsDouble}");

            // Explicit Conversion
            int attackPowerAsInt = (int)attackPower; 
            Console.WriteLine($"Attack Power as int (explicit conversion): {attackPowerAsInt}");

            // Convert Class
            int experienceAsInt = Convert.ToInt32(experiencePoints);  
            Console.WriteLine($"Experience Points as int (using Convert): {experienceAsInt}");

            // Parsing a string to a double
            string currencyString = "150.3333333";
            double parsedCurrency;
            bool isCurrencyParsed = double.TryParse(currencyString, out parsedCurrency); 
            if (isCurrencyParsed)
            {
                Console.WriteLine($"Gold Coins (parsed from string): {parsedCurrency}");
            }
            else
            {
                Console.WriteLine("The currency string is not a valid double.");
            }

            
            int parsedNumber;
            bool isParseSuccessful = int.TryParse(characterName, out parsedNumber); 
            if (isParseSuccessful)
            {
                Console.WriteLine($"Successful parse '{characterName}' to number: {parsedNumber}");
            }
            else
            {
                Console.WriteLine($"Parsing failed: '{characterName}' is not a number value.");
            }
        }
    }
}
