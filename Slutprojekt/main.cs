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

            statistics character = new statistics();

            Console.WriteLine("Create a character:\n");

            characterBuilder.Race();

            Console.WriteLine(character.race);
            Console.ReadLine();
        }
    }
}
