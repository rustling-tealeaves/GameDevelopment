namespace Ritarin_sekoilut
{
    internal class Ritarin_sekoilut
    {
        static void Main(string[] args)
        {
            // Set starting HP for the main characters
            int hpKnight = 15;
            int hpOrc = 15;

            // Create instance of the Random class
            Random random = new Random();

            PrintSituation(hpKnight, hpOrc); // Prints three lines, telling the situation
            string chosenAction = ChooseAction(); // Get a valid input from user
            int damage = RollDamageDie(random); // An oddly complicated Random.Next
        }

        // Prints the current HP situation
        static void PrintSituation(int hpKnight, int hpOrc)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Knight HP: {hpKnight}/15");
            Console.WriteLine($"Orc HP: {hpOrc}/15");
        }

        // Makes the player choose a valid action from choices available
        static string ChooseAction()
        {
            Console.ResetColor(); // Reset colours, just in case
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Change text colour to dark yellow
            Console.WriteLine("Now, what shall you do?");
            Console.ForegroundColor = ConsoleColor.Yellow; // Change text colour to yellow
            Console.WriteLine("1 - Attack with your sword");
            Console.WriteLine("2 - Defend with your shield");
            Console.ResetColor(); // Reset colours

            while (true)
            {
                string chosenAction = Console.ReadLine();

                // Make sure the input is valid
                if (chosenAction == "1" || chosenAction == "2")
                {
                    return chosenAction;
                }
                else
                {
                    Console.WriteLine("Invalid action, try again.");
                }
            }

        }

        // The oddly complicated Random.Next
        static int RollDamageDie(Random random)
        {
            return random.Next(1, 7); // Roll 1d6
        }
    }
}
