using System.Linq.Expressions;
using System.Data;
using System;

namespace Slutprojekt
{
    public class characterBuilder
    {   


        public static statistics Race()
        {

            statistics character = new statistics();

            Console.WriteLine("Race:");
            Console.WriteLine("1. Human       2. Gnome       3. Ork       4. Italian");

            if ("1" == Console.ReadLine() || "Human" == Console.ReadLine() || "human" == Console.ReadLine())
            {
                character.race = "Human";
            }
            else if ("2" == Console.ReadLine() || "Gnome" == Console.ReadLine() || "gnome" == Console.ReadLine())
            {
                character.race = "Gnome";
            }
            else if ("3" == Console.ReadLine() || "Ork" == Console.ReadLine() || "ork" == Console.ReadLine())
            {
                character.race = "Ork";
            }
            else if ("4" == Console.ReadLine() || "Italian" == Console.ReadLine() || "italian" == Console.ReadLine())  
            {
                character.race = "Italian";
            }
            else
            {
                Console.WriteLine("Something's wrong, try again!");
                Console.Clear();
                Race();
            }

            return Build(character);

            
        }

        public static statistics Build(statistics chr)
        {

            Console.WriteLine("\nBuild:");
            Console.WriteLine("1. Knight       2. Wizard       3. Brawler       4. Thief");

            Console.ReadLine();

            return chr;
        }
    }
}