using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponttavolsag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az x1 pontot: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg az x2 pontot: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg az y1 pontot: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg az y2 pontot: ");
            double y2 = double.Parse(Console.ReadLine());
            double tav = 0;
            tav = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

            Console.WriteLine("Két pont távolsága:{0}", tav);
            Console.ReadKey();
        }
    }
}
