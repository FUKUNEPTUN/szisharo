using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        public Menu() { }
        public void karacsonyi()
        {
            int a = 0;
            Console.WriteLine("1 Első menüpont|| 2 második menüpont || 3 Harmadik menüpont || 4 Negyedik menüpont || 5 Kilépés");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            while (a != 1)
            { 
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Első menüpont");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        Console.WriteLine("1 Első menüpont|| 2 második menüpont || 3 Harmadik menüpont || 4 Negyedik menüpont || 5 Kilépés");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        break;
                case "2":
                    Console.WriteLine("Második menüpont");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        Console.WriteLine("1 Első menüpont|| 2 második menüpont || 3 Harmadik menüpont || 4 Negyedik menüpont || 5 Kilépés");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        break;
                case "3":
                    Console.WriteLine("Harmadik menüpont");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        Console.WriteLine("1 Első menüpont|| 2 második menüpont || 3 Harmadik menüpont || 4 Negyedik menüpont || 5 Kilépés");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        break;
                case "4":
                    Console.WriteLine("Negyedik menüpont");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        Console.WriteLine("1 Első menüpont|| 2 második menüpont || 3 Harmadik menüpont || 4 Negyedik menüpont || 5 Kilépés");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        break;
                case "5":
                    Console.WriteLine("Sikeresen kiléptél");
                    a++;
                    break;
                default:

                        Console.WriteLine("Ilyen menüpont nem létezik.");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("1 Első menüpont|| 2 második menüpont || 3 Harmadik menüpont || 4 Negyedik menüpont || 5 Kilépés");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        ; break;
                       
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu(); 
            menu.karacsonyi();
            Console.ReadKey();
        }
    }
}
