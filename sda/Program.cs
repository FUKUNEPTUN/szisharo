using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ehes ehes = new Ehes();
            ehes.setSzam();
            Console.WriteLine(ehes.getSzam(3));
            Console.ReadKey();
        }
    }
}
