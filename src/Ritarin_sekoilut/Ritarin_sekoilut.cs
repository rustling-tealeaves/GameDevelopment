namespace Ritarin_sekoilut
{
    internal class Ritarin_sekoilut
    {
        static void Main(string[] args)
        {
            // Kaksi kokonaislukua (integer)
            int hpRitari = 15;
            int hpOrkki = 15;

            // Luodaan random-luokan instanssi
            Random random = new Random();

            // Vaihda tekstin väri
            Console.ForegroundColor = ConsoleColor.Cyan;
            // Tulosta tekstiä ruudulle
            Console.WriteLine("Hello, Brave Adventurer. Time to kill Orc!");
            // Palauta oletusvärit
            Console.ResetColor();

            while (true)
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine($"Ritarin HP: {hpRitari}/15");
                Console.WriteLine($"Örkin HP: {hpOrkki}/15");
                Console.ForegroundColor = ConsoleColor.Yellow; // Vaihda tekstin väri
                Console.WriteLine("1 - Hyökkää miekalla");
                Console.WriteLine("2 - Puolustaudu kilvellä");
                Console.ResetColor(); // Palauta oletusvärit
                Console.WriteLine("Anna komento: ");
                string vastaus = Console.ReadLine();

                // Arvo örkin tekemä vahinko
                int orkin_vahinko = random.Next(1, 7); // Roll 1d6
                // Arvo ritarin tekemä vahinko
                int ritarin_vahinko = random.Next(1, 9); // Roll 1d8

                // Ritarin vuoro
                Console.ForegroundColor = ConsoleColor.Green; // Vaihda tekstin väri
                if (vastaus == "1")
                {
                    // atakk
                    Console.WriteLine("Hyökkäät miekallasi!");
                    hpOrkki -= ritarin_vahinko; // Vähennä ritarin vahingon verran
                    Console.WriteLine($"Sivallat örkkiä miekallasi. Teet örkkiin {ritarin_vahinko} pistettä vahinkoa.");
                    if (hpOrkki <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Kukistit vihollisesi!");
                        Console.ResetColor();
                        break;
                    }
                }
                else if (vastaus == "2")
                {
                    // protecc: Örkki tekee vähemmän vahinkoa
                    Console.WriteLine("Nostat kilpesi puolustuksesi!");
                    orkin_vahinko /= 2; // Puolet vahinkoa
                }
                else // Kaikissa muissa tapauksissa...
                {
                    Console.WriteLine("En ymmärrä!");
                }
                Console.ResetColor(); // Palauta oletusvärit

                // Örkin vuoro tehdään vain jos örkki on elossa
                // vahingon määrä riippuu siitä, puolustaako ritari
                Console.ForegroundColor = ConsoleColor.Red; // Vaihda tekstin väri

                if (hpOrkki > 0)
                {
                    Console.WriteLine("Örkki hyökkää sinua kohti nuijallaan!");
                    hpRitari -= orkin_vahinko;

                    if (vastaus == "2")
                        Console.WriteLine($"Nuija kumahtaa kilpeesi, tehden sinuun vain {orkin_vahinko} vahinkoa.");
                    else
                        Console.WriteLine($"Nuija osuu sinuun, tehden {orkin_vahinko} vahinkoa.");

                    if (hpRitari <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Vihollisesi on kukistanut sinut...");
                        Console.ResetColor();
                        break;
                    }
                }
                Console.ResetColor(); // Palauta oletusvärit
            }
        }

        static void Damage()
        {
            // Contents here
        }
    }
}
