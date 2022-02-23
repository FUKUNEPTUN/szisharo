using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legnagyobb
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 1, a2 = 0, a3 = 0;
            while(a1 != 0)
            {
                a1 = Convert.ToInt32(Console.ReadLine());
                if (a1 > a2)
                {
                    a2 = a1;
                }
            }
            Console.WriteLine("A bekért számok közül a legnagyobb a {0} volt", a2);
            Console.ReadKey();
        }
    }
}
