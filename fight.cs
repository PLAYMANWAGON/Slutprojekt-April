using System.Xml;
using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
namespace Slutprojekt
{
    public class actionFight
    {
        public static void fight()
        {
            
        
            statistics character = new statistics();
            statistics enemy = new statistics();

            int generator = new Random();

            int enemy = 0;

            string enemyName = "";

            enemy = generator(3);

            if (enemy = 0) {
                enemy.health = 100;
                enemy.damage = 1;
                enemyName = "Bandit";
            }

            else if (enemy = 1) {
                enemy.health = 120;
                enemy.damage = 0.8;
                enemyName = "Maurader";
            }

            else if (enemy = 2) {
                enemy.health = 80;
                enemy.damage = 1.2;
                enemyName = "Midget";
            }

            else {
                enemy.health = 80;
                enemy.damage = 0.5;
                enemyName = "Albanian";
            }

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

            Console.WriteLine("A wild " + enemyName + " appears! What will you do?");
            Console.WriteLine("1. Fight       2. Talk it out       3. Inventory       4. Just leave");
            Console.ReadLine();

            

        }

        
    }
}
