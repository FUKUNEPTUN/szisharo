using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibon
    {
        public Fibon() { }
        private List<ulong> lista = new List<ulong>();
        private int bead;
        public void megold()
        {
            lista.Add(0);
            lista.Add(1);
            Console.WriteLine("Írd be hány számot szeretnél látni a Fibonacci sorozatból!");
            bead = int.Parse(Console.ReadLine());
            for (int i = 1; i < bead; i++)
            {
                lista.Add(lista[i - 1] + lista[i]);
            }
            Console.WriteLine("Fibonacci számok a következőek a beírt érték alapján: {0}", bead);
            foreach (var kiad in lista)
            {
                Console.WriteLine(kiad);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fibon megoldas = new Fibon();
            megoldas.megold();
            Console.ReadKey();
        }
    }
}