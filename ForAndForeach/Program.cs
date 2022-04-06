using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForeach
{
    class ForAndForeach
    {
        public ForAndForeach() { }
        private int[] tomb = new int[15];
        private Random rdm = new Random();
        public void feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rdm.Next(1, 99);
            }
        }
        public void ForC()
        {
            Console.WriteLine("=========================================\nTömb kiírása FOR ciklussal\n=========================================");
            for (int k = 0; k < tomb.Length; k++)
            {
                Console.WriteLine(tomb[k]);
            }
        }
        public void ForeachC()
        {
            Console.WriteLine("=========================================\nTömb kiírása FOREACH ciklussal\n=========================================");
            foreach (var index in tomb)
            {
                Console.WriteLine(index);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ForAndForeach megold = new ForAndForeach();
            megold.feltolt();
            megold.ForC();
            megold.ForeachC();
            Console.ReadKey();
        }
    }
}