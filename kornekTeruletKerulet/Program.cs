using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korterker
{
    class Kor
    {
        // Osztályváltozók
        protected int r;
        private double terulet,
            kerulet;

        public Kor() { }

        public Kor(int r, double terulet, double kerulet)
        {
            this.r = r;
            this.terulet = terulet;
            this.kerulet = kerulet;
        }

        public double terszamitas()
        {
            this.terulet = Math.Pow(getBekeres(), 2) * Math.PI;
            return this.terulet;
        }

        public double kerszamitas()
        {
            this.kerulet = 2 * getBekeres() * Math.PI;
            return this.kerulet;
        }

        public void setBekeres()
        {
            int ertek = Convert.ToInt32(Console.ReadLine());
            if (ertek != 0)
            {
                this.r = ertek;
            }
        }

        public double getBekeres()
        {
            return this.r;
        }
    }

    class Henger : Kor
    {
        // Osztályváltozók
        private double terfogat,
            magassag;

        public Henger() : base() { } // Konstruktor

        public Henger(double magassag, double terfogat)
        {
            this.magassag = magassag;
            this.terfogat = terfogat;
        }

        public void setMagassag()
        {
            double magasertek = Convert.ToInt32(Console.ReadLine());
            if (magasertek != 0)
            {
                this.magassag = magasertek;
            }
        }

        public double getMagassag()
        {
            return this.magassag;
        }

        public double Terfogat()
        {
            this.terfogat = getMagassag() * terszamitas();
            return this.terfogat;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a sugarat: ");
            Henger a = new Henger();
            a.setBekeres();
            Console.WriteLine("A kör sugara: {0}, területe: {1}, a kör kerülete: {2}.", a.getBekeres(), a.terszamitas(), a.kerszamitas());

            Console.WriteLine("Add meg a henger magasságát: ");
            a.setMagassag();
            Console.WriteLine("A henger térfogata: {0}", a.Terfogat());

            Console.ReadKey();
        }
    }
}