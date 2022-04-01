using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        /// <summary>
        /// itt csak a Console.Clear() az érdekes, ezzel mindig kitörlöm a hátramaradt szemetet, így szép marad, de amugy egy teljesen egyszerű kód,
        /// 100%-ban megegyezzik azzal amit órán csináltunk tanár úrral táblánál
        /// </summary>
        public Menu() { }
        public void husveti()
        {
            int a = 0;

            while (a != 1)
            {
                Console.WriteLine("1 Első menüpont|| 2 második menüpont || 3 Harmadik menüpont || 4 Negyedik menüpont || 5 Kilépés");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                
                switch (Console.ReadLine())
            {
                case "1":
                        Console.Clear();
                        Console.WriteLine("Első menüpont");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        break;
                case "2":
                        Console.Clear();
                        Console.WriteLine("Második menüpont");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        break;
                case "3":
                        Console.Clear();
                        Console.WriteLine("Harmadik menüpont");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        break;
                case "4":
                        Console.Clear();
                        Console.WriteLine("Negyedik menüpont");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        break;
                case "5":
                        Console.Clear();
                        Console.WriteLine("Sikeresen kiléptél");
                    a++;
                    break;
                default:
                        Console.Clear();
                        Console.WriteLine("Ilyen menüpont nem létezik.");
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
            menu.husveti();
            Console.ReadKey();
        }
    }
}
