using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace henger
{
    class Kör
    {
        private double sugar;
        public Kör() { }
        public void Beker()
        {
            Console.WriteLine("Adja meg a kör a sugarát");
            this.sugar = Convert.ToDouble(Console.ReadLine());
        }

        public double Terulet()
        {
            return Math.Round(this.sugar * this.sugar * Math.PI, 2);
        }
        public double Kerulet()
        {
            return Math.Round(2 * this.sugar * Math.PI, 2);
        }
    }
    class Henger : Kör {
        private double magassag;
        public Henger() : base(){}
        public void Beker2()
        {
            this.Beker();
            Console.WriteLine("Adja meg a henger magasságát");
            this.magassag = Convert.ToDouble(Console.ReadLine());
        }
        public double Palast()
        {
            return Math.Round(this.Kerulet() * this.magassag, 2);
        }
        public double Terfogat()
        {
            return Math.Round( this.Terulet() * this.magassag, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Kör teszt1 = new Kör();
            teszt1.Beker();
            Console.WriteLine("A kör területe: {0} és a kerülete {1}", teszt1.Terulet(),teszt1.Kerulet());
            Console.WriteLine("--------------------------------------");
            Henger teszt2 = new Henger();
            teszt2.Beker2();
            Console.WriteLine("A henger palást területe: {0} és a henger térfogata {1}", teszt2.Palast(), teszt2.Terfogat());

            Console.ReadKey();
        }
        
    }
}
