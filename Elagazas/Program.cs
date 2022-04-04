using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas
{
    class Elagaz
    {
        public Elagaz() { }
        List<int> lista, paros;
        Random random = new Random();
        int[] tomb = new int[] { };
        public void ficko()
        {
            lista = new List<int>();
            paros = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lista.Add(random.Next(0, 100));
            }
            Console.WriteLine("Lista elemei:");
            foreach (var szam in lista)
            {
                Console.WriteLine("Elem: {0}", szam);
                if (szam % 2 == 0)
                {
                    paros.Add(szam);
                }
            }
            Console.WriteLine("Páros számok a listában:");
            foreach (var aa in paros)
            {
                Console.WriteLine("{0}", aa);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Elagaz gaz = new Elagaz();
            gaz.ficko();
            Console.ReadKey();
        }
    }
}