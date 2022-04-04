using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullak
{
    class Nullak
    {
        int szamol = 0, max = 0;
        int index;
        string[] teszt = new string[8];
        public Nullak() { }
        public void mi()
        {
            Console.WriteLine("Érték");
            Random rnd = new Random();
            //Convert.ToString(rnd.Next(0,20000))
            string data = "100000",teszt2;
            for (int i = 0; i < teszt.Length; i++)
            {
                teszt[i] = Convert.ToString(rnd.Next(100, 1000000));
                Console.WriteLine(teszt[i]);
            }
            for (int i = 0; i < teszt.Length; i++)
            {
                teszt2 = teszt[i];
                for (int j = 0; j < teszt2.Length; j++)
                {

                    if (teszt2[j] == '0')
                    {
                        ++szamol;
                    }
                }
                if (szamol > max)
                {
                    max = szamol;
                    index = i;
                }
                szamol = 0;

            }
            
            Console.WriteLine("Generált számok: {0} \t Legtöbb nullával rendelkező szám: {1} \t Benne talált nullák száma: {2}",szamol, teszt[index],max);
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullak mi = new Nullak();
            mi.mi();
            Console.ReadLine();
        }
    }
}
