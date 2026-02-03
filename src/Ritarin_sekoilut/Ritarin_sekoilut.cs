namespace Ritarin_sekoilut
{
    internal class Ritarin_sekoilut
    {
        static void Main(string[] args)
        {
            ChooseAction(); // Placeholder so the method is bright while I'm working on it
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

            string chosenAction = Console.ReadLine();

            return chosenAction;
        }
    }
}
