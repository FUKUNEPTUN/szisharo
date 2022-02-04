using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int param = args.Length;
            int szam1 = 0;
            int szam2 = 0;
            Random rnd = new Random();
            switch (param)
            {
                case 0:
                    szam1 = rnd.Next(1, 100);
                    szam2 = rnd.Next(1, 100);
                    break;
                case 1:
                    szam1 = int.Parse(args[0]);
                    szam2 = rnd.Next(1, 100);
                    break;
                case 2:
                    szam1 = int.Parse(args[0]);
                    szam1 = int.Parse(args[0]);
                    break;
            }
            Console.WriteLine(szam2 * szam1);
            Console.ReadKey();
        }
    }
}
