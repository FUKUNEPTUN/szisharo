using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtomegindex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a testtomeget(kg)");
            double testtomeg = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a testmagassagot(cm)");
            double testmagassag = Convert.ToDouble(Console.ReadLine());
            double bmi = 0;        
            testmagassag = testmagassag / 100;
            bmi = testtomeg / (testmagassag * testmagassag);

            Console.WriteLine(bmi);
            if (bmi <= 18.5)
            {
                Console.WriteLine("sovány");
            }
            else if (bmi >= 18.6 && bmi <= 25)
            {
                Console.WriteLine("normál");
            }
            else if (bmi >= 26 && bmi <= 30)
            {
                Console.WriteLine("kövér");
            }
            else if (bmi > 30)
            {
                Console.WriteLine("dagadt");
            }
            Console.ReadKey();
        }
    }
}
