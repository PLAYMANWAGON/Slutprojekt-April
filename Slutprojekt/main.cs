using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==================================================");
            Console.WriteLine(" ██████╗  █████╗ ███╗   ███╗██╗███╗   ██╗ ██████╗ ");
            Console.WriteLine("██╔════╝ ██╔══██╗████╗ ████║██║████╗  ██║██╔════╝ ");
            Console.WriteLine("██║  ███╗███████║██╔████╔██║██║██╔██╗ ██║██║  ███╗");
            Console.WriteLine("██║   ██║██╔══██║██║╚██╔╝██║██║██║╚██╗██║██║   ██║");
            Console.WriteLine("╚██████╔╝██║  ██║██║ ╚═╝ ██║██║██║ ╚████║╚██████╔╝");
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝╚═╝  ╚═══╝ ╚═════╝ ");
            Console.WriteLine("==================================================");


            // Använder detta for loopen för att kunna lättare bestämma avståndet mellan "press enter to play" och bannern 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine("                  Press Enter to Play");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Create a character:\n");

            statistics hero = characterBuilder.Race();

            Console.WriteLine("you are a " + hero.race + " and your class is a " + hero.build);
            Console.ReadLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Fight       2. Store       3. Inventory       4. Quit");

            string action = Console.ReadLine();

            if (action == "1" || action == "Fight" || action == "fight")
            {


            }

        }
    }
}
