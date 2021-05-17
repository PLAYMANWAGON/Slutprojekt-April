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

            string input = "";
            bool mistake = true;
            
            while (mistake == true)
            {

                Console.WriteLine("Race:");
                Console.WriteLine("1. Human       2. Gnome       3. Ork       4. Italian");

                input = Console.ReadLine();

                if ("1" == input || "Human" == input || "human" == input)
                {
                    character.race = "Human";
                    mistake = false;
                }
                else if ("2" == input || "Gnome" == input || "gnome" == input)
                {
                    character.race = "Gnome";
                    mistake = false;
                }
                else if ("3" == input || "Ork" == input || "ork" == input)
                {
                    character.race = "Ork";
                    mistake = false;
                }
                else if ("4" == input || "Italian" == input || "italian" == input)
                {
                    character.race = "Italian";
                    mistake = false;
                }
                else
                {
                    Console.WriteLine("You typed something, try again!");
                    Console.Clear();
                }

            }

            return character;

        }
    }
}