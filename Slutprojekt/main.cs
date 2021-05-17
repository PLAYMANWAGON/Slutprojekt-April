using System.Net.Http.Headers;
using System.IO.MemoryMappedFiles;
using System.Security.AccessControl;
using System.Collections.Generic;
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
            Console.Clear();


            Console.WriteLine("you are a " + hero.race + " and your job is too slay those who oppose your village!");
            Console.ReadLine();

            bool repeat = true;

            while (repeat == true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Fight       2. Store       3. Inventory       4. Quit");

                string action = Console.ReadLine();

                if (action == "1" || action == "Fight" || action == "fight")
                {   
                    // hur fan funkar klasser jag legit förstår inte den här jävla skiten
                    // actionFight.fight();

                    Console.WriteLine("this action is work in progress,  come back later");
                    Console.ReadLine();
                
                }

                if (action == "2" || action == "Store" || action == "store")
                {
                    Console.WriteLine("The store is closed... come back some other time.");
                    Console.ReadLine();
                }

                if (action == "3" || action == "Inventory" || action == "inventory")
                {
                    List<string> inventory  = new List<string>()
                    {"Onion", "Dagger", "Bread"};

                    bool repeat2 = true;

                    while (repeat2 == true)
                    {

                        Console.WriteLine("Your Moncler backpack contains: ");
                        inventory.ForEach(i => Console.Write("{0}\t", i));
                        Console.WriteLine();
                        Console.WriteLine("What would you like to do with them? (Type in the item, it's respective actions will be displayed");
                        string inventoryAction = Console.ReadLine();

                        bool repeat3 = true;

                        while (repeat3 == true)
                        {
                            if (inventoryAction == "1" || inventoryAction == "Onion" || inventoryAction == "onion")
                            {
                                Console.WriteLine("1. Eat       2. Throw away      3. Back");
                                string inventory1Action = Console.ReadLine();

                                if (inventory1Action == "1" || inventory1Action == "Eat" || inventory1Action == "eat")
                                {
                                    Console.WriteLine("You eat the onion, it leaves a foul taste in your mouth...");
                                    inventory.Remove("Onion");
                                    Console.ReadLine();
                                }

                                if (inventory1Action == "3" || inventory1Action == "Back" || inventory1Action == "back")
                                {
                                    Console.Clear();
                                    repeat3 = false;
                                }
                                
                            }
                            if (inventoryAction == "back")
                            {
                                Console.Clear();
                                repeat2 = false;
                            }
                        }
                    }
                }
                 if (action == "4" || action == "Quit" || action == "quit")
                {
                    System.Environment.Exit(1);
                    
                }
            }
        }
    }
}

