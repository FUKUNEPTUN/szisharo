using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    class Binaris
    {      
        public Binaris() { }
        public void csiriBu()
        {
            Console.WriteLine("Add még az értékeket! (0/1)");
            string data = Console.ReadLine();
            int szamolo = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '1')
                {
                    szamolo++;
                }
            }
            Console.WriteLine("{0} darab egyes található ebben a bináris számsorban",szamolo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Binaris csiriBa = new Binaris();
            csiriBa.csiriBu();
            Console.ReadLine();

        }
    }
}
