using System.Xml;
using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
namespace Slutprojekt
{
    public class fight
    {
        public static void fight()
        {
            
        
            statistics character = new statistics();
            statistics enemy = new statistics();

            if (character.race = "Human") {

            character.health = 100;
            character.damage = 1;
            }

            else if (character.race = "Gnome") {

            character.health = 60;
            character.damage = 1.5;
            }

            else if (character.race = "Ork") {

            character.health = 140;
            character.damage = 0.7;
            }

            else {

            character.health = 200;
            character.damage = 2;
            }

        }

        
    }
}
