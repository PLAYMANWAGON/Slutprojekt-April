using System;

namespace Slutprojekt
{
    class characterBuilder
    {

        public static void Race()
        {

            Console.WriteLine("Race:");
            Console.WriteLine("1. Human       2. Gnome       3. Ork       4. Vampire");

            Console.ReadLine();

            Class();

        }

        static void Class()
        {
            Console.WriteLine("\nClass:");
            Console.WriteLine("1. Knight       2. Wizard       3. Brawler       4. Thief");

            Console.ReadLine();
        }
    }
}