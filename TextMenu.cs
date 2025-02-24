using System;
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
                Console.WriteLine("1. Make Employee 1");
                Console.WriteLine("2. Make Employee 2");
                Console.WriteLine("3. Choiсe");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Employee employee1 = new Employee(12, "TestN1", "TestP1", 22);
                        employee1.DisplayEmployeeInfo();
                        break;
                    case "2":
                        Employee employee2 = new Employee(12, "TestN2", "TestP2", 22);
                        employee2.DisplayEmployeeInfo();
                        break;
                    case "3":
                        ;
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

}



