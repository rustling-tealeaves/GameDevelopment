namespace Ritarin_sekoilut
{
    internal class Ritarin_sekoilut
    {
        static void Main(string[] args)
        {
            ChooseAction(); // Placeholder so the method is bright while I'm working on it
        }

        // Makes the player choose a valid action from choices available
        static void ChooseAction()
        {
            Console.ResetColor(); // Reset colours, just in case
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Change the colour of the text to dark yellow
            Console.WriteLine("Now, what shall you do?");
            Console.ForegroundColor = ConsoleColor.Yellow; // Change the colour of the text to yellow
            Console.WriteLine("1 - Attack with your sword");
            Console.WriteLine("2 - Defend with your shield");
            Console.ResetColor(); // Reset colours

            // Define variables for the different options
            // string actionAttack = "1 - Attack with your sword";
            // string actionDefend = "2 - Defend with your shield";
        }
    }
}
