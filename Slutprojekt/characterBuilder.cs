using System;

namespace Slutprojekt
{
    public class characterBuilder
    {        

        public static void Race()
        {

            statistics character = new statistics();

            Console.WriteLine("Race:");
            Console.WriteLine("1. Human       2. Gnome       3. Ork       4. Vampire");

            character.race = Console.ReadLine();

            Console.WriteLine("\nBuild:");
            Console.WriteLine("1. Knight       2. Wizard       3. Brawler       4. Thief");

            Console.ReadLine();
        }
    }
}