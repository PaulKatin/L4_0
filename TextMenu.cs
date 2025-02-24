﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_0
{
    
        internal class TextMenu
        {
            public void DisplayTextMenu()
            {
                while (true)
                {
                    Console.WriteLine("Take Choice");
                    Console.WriteLine("1. Choiсe");
                    Console.WriteLine("2. Choiсe");
                    Console.WriteLine("3. Choiсe");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Select an option: ");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Choiсe1();
                            break;
                        case "2":
                            Choiсe2();
                            break;
                        case "3":
                            Choiсe3();
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }

            static void Choiсe1()
            {
                Console.WriteLine("Choiсe1");

            }

            static void Choiсe2()
            {
                Console.WriteLine("Choiсe2");
            }

            static void Choiсe3()
            {
                Console.WriteLine("Choiсe3");
            }
        }
}


