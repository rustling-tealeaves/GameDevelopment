using System;

namespace Ritarin_sekoilut
{
    internal class Ritarin_sekoilut
    {
        // Define max HP for different characters
        static readonly int MaxHpKnight = 15;
        static readonly int MaxHpOrc = 15;

        static void Main(string[] args)
        {
            // Set starting HP for the main characters
            int hpKnight = MaxHpKnight;
            int hpOrc = MaxHpOrc;

            // Create instance of the Random class
            Random random = new Random();

            // Gameplay loop
            SimulateGame(hpKnight, hpOrc, random);

        }

        // Main gameplay loop, neatly inside a function
        static void SimulateGame(int hpKnight, int hpOrc, Random random)
        {
            PrintIntroFluff();
            while (hpKnight > 0 && hpOrc > 0)
            {
                PrintSituation(hpKnight, hpOrc); // Prints two lines, telling the situation
                string chosenAction = ChooseAction(); // Get a valid input from user
                int hpOrcNew = CalculateNewHpOrc(hpOrc, chosenAction, random); // Knight's turn...
                int hpKnightNew = CalculateNewHpKnight(hpKnight, chosenAction, random); // ...and Orc's turn.
                hpKnight = hpKnightNew;
                hpOrc = hpOrcNew;
            }
            PrintSituation(hpKnight, hpOrc);
        }

        // Prints the chosen intro fluff; change contents if needed
        static void PrintIntroFluff()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You are an aspiring knight, \non a foolhardy quest to slay an orc.");
            Console.WriteLine("Your enemy is the first to notice you.");
            Console.WriteLine("You've no chance to escape.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("May you prevail!");
            Console.ResetColor();
        }

        // Prints the current HP situation
        static void PrintSituation(int hpKnight, int hpOrc)
        {
            Console.WriteLine(new string('-', 50));
            Console.Write($"Knight HP: {hpKnight}/{MaxHpKnight}");
            Console.WriteLine($"  Orc HP: {hpOrc}/{MaxHpOrc}");
        }

        // Makes the player choose a valid action from choices available
        static string ChooseAction()
        {
            Console.ResetColor(); // Reset colours, just in case
            Console.ForegroundColor = ConsoleColor.Yellow; // Set text colour to yellow
            Console.WriteLine("1 - Attack with your sword");
            Console.WriteLine("2 - Defend with your shield");
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Set text colour to dark yellow
            Console.Write("Now, what shall you do? ");
            Console.ResetColor(); // Reset colours

            while (true)
            {
                string chosenAction = Console.ReadLine();

                // Make sure the input is valid
                if (chosenAction == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Set text colour to green
                    Console.WriteLine("You attack with your sword!");
                    Console.ResetColor(); // Reset colours
                    return chosenAction;
                }
                else if (chosenAction == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Set text colour to green
                    Console.WriteLine("You raise your shield in defense!");
                    Console.ResetColor(); // Reset colours
                    return chosenAction;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan; // Set text colour to cyan
                    Console.WriteLine("Invalid action, try again.");
                    Console.ResetColor(); // Reset colours
                }
            }

        }

        // The oddly complicated Random.Next
        static int RollDamageDie(Random random)
        {
            return random.Next(1, 7); // Roll 1d6
        }

        // Calculate what hpOrc should be at end of turn, based on what Knight does
        static int CalculateNewHpOrc(int hpOrc, string chosenAction, Random random)
        {
            // If Knight defends, hpOrc won't change
            if (chosenAction == "2")
            {
                return hpOrc;
            }

            // Otherwise, make the attack happen (soonTM)
            int damage = RollDamageDie(random); // An oddly complicated Random.Next
            Console.ForegroundColor = ConsoleColor.Green; // Set text colour to green
            Console.WriteLine($"Your attack lands. The orc takes {damage} damage.");
            Console.ResetColor(); // Reset colours
            return Math.Clamp(hpOrc - damage, 0, MaxHpOrc); // Don't go below 0
        }

        // Calculate what hpKnight should be at end of turn, based on... what Knight does.
        static int CalculateNewHpKnight(int hpKnight, string chosenAction, Random random)
        {
            // The orc attacks, every time.
            Console.ForegroundColor = ConsoleColor.Red; // Set text colour to red
            Console.WriteLine("The orc attacks you with its club!");

            // Calculate base damage
            int damage = RollDamageDie(random); // An oddly complicated Random.Next

            // If Knight doesn't defend, take full damage
            if (chosenAction == "1")
            {
                Console.WriteLine($"The club hits you, causing {damage} damage.");
            }

            // If Knight defends, take half damage
            else if (chosenAction == "2")
            {
                damage /= 2;
                Console.WriteLine($"The club hits your shield, causing only {damage} damage to you.");
            }

            Console.ResetColor(); // Reset colours
            return Math.Clamp(hpKnight - damage, 0, MaxHpKnight);
        }
    }
}
