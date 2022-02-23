using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine()),
                a = Convert.ToInt32(Console.ReadLine()); 
            while(i <= a)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
