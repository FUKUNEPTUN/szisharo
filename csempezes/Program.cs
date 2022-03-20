using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempezes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            double szel,
                mely,
                terulet,
                darabszam,
                csempemeret;

            Console.WriteLine("Kérem a szoba szélességét! (méter)");
            szel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a szoba mélységét! (méter)");
            mely = Convert.ToDouble(Console.ReadLine());

            csempemeret = Math.Pow(0.2, 2);

            terulet = szel * mely;

            darabszam = (terulet / csempemeret) * 1.1;

            Console.WriteLine("A szükséges csempék száma: {0} db.", darabszam);
            Console.ReadKey();
        }
    }
}