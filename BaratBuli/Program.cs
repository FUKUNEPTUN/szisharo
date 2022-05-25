using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buliszervezés
{
    class BLapoz
    {
        private string nev;
        private DateTime szuletes;
        private char nem;
        private int buli;
        private string sor; // Egy sor beolvasása
        private string[] mezo; // Sor szétbontása



        public BLapoz() { }

        public BLapoz(string nev, DateTime szuletes, char nem, int buli)
        {
            this.nev = nev;
            this.szuletes = szuletes;
            this.nem = nem;
            this.buli = buli;
        }

        public void printBarat()
        {
            Console.WriteLine("{0,-20} {1,-10} {2,1} {3}", this.nev, this.szuletes.ToShortDateString(), this.nem, this.buli);
        }
        private List<BLapoz> baratLista = new List<BLapoz>(); // Ebben tároljuk a barát dokumentumot + lista létrehozás
        private List<BLapoz> Blist20 = new List<BLapoz>(); // Barátok akik 20 évnél idősebbek
        public void bekeres()
        {

            if (!File.Exists("baratlapoz.txt"))
            {
                Random r = new Random();
                int k,é,h,n;
                // Create a file to write to.
                using (StreamWriter wr = File.CreateText("baratlapoz.txt"))
                {
                    for (int i = 0; i < 160; i++)
                    {
                        k = r.Next(1, 10);
                        é = r.Next(2002, 2005);
                        h = r.Next(1, 12);
                        n = r.Next(1, 30);
                        if (h == 2)
                        {
                            n = r.Next(1, 28);
                        }
                        wr.WriteLine("{0}. Erzsébet Királynő,{2}.{3}.{4},n,{1}", i, k,é,h,n);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("baratlapoz.txt", Encoding.UTF8))
                while (sr.EndOfStream == false)
                {
                    sor = sr.ReadLine();
                    if (sor.Trim().Length == 0) continue; // Ha üres a sor, akkor léptetünk

                    mezo = sor.Split(','); // Szétbontás

                    // Hozzáadás a listához
                    baratLista.Add(new BLapoz(
                        mezo[0],
                        DateTime.Parse(mezo[1]),
                        char.Parse(mezo[2]),
                        int.Parse(mezo[3])));
                    if (DateTime.Parse(mezo[1]) < DateTime.Parse("2002.05.21") && int.Parse(mezo[3]) >= 5)
                    {
                        Blist20.Add(new BLapoz(
                        mezo[0],
                        DateTime.Parse(mezo[1]),
                        char.Parse(mezo[2]),
                        int.Parse(mezo[3])));
                    }
                }
        }
        public void Kiir()
        {
            Console.WriteLine("Barátaink:");
            foreach (BLapoz key in baratLista)
            {
                key.printBarat();
            }
            Console.WriteLine();
            Console.WriteLine("A buliba meghívható barátaink neve:");
            foreach (BLapoz key in Blist20)
            {
                if (Blist20.Count >= 10)
                {
                    Console.WriteLine("{0,-20}", key.nev);
                }
                else { Console.WriteLine("Sajnos 10 fő kell a buli szervezéséhez"); }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BLapoz bl = new BLapoz();
            bl.bekeres();
            bl.Kiir();
            Console.ReadKey();
        }
    }
}