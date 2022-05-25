using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaratLapoz
{
    class BaratLapoz
    {
        //================================================================== változók =====================================================================
        private string nev;
        private DateTime szuletesi_datum;
        private char neme;
        private int bulizasi_hajlam , tovabb = 0;
        private string s;
        private string[] ss;



        public BaratLapoz() { }

        public BaratLapoz(string nev, DateTime szuletesi_datum, char neme, int bulizasi_hajlam )
        {
            this.nev = nev;
            this.szuletesi_datum = szuletesi_datum;
            this.neme = neme;
            this.bulizasi_hajlam  = bulizasi_hajlam ;
        }
        //==================================================================== Kiíratáshoz használt metódus =======================================================================================

        public void printBarat()
        {
            Console.WriteLine("{0,-20} {1,-10} {2,1} {3}", this.nev, this.szuletesi_datum.ToShortDateString(), this.neme, this.bulizasi_hajlam ); //Consolera soronként kiirja az adatokat
        }
        private List<BaratLapoz> baratLista = new List<BaratLapoz>();
        //==================================================================== Fájl kezelés =======================================================================================

        public void bekeres()
        {
            //*************Ha nem létezik a barat.txt, akkor géppel legeneráltatom a filet, hogy ne nekem kelljen ezzel foglalkozni, persze igény szerint módosíthatóak az adatok*****
            if (!File.Exists("barat.txt"))
            {
                Random r = new Random();
                int k;
                // Create a file to write to.
                using (StreamWriter wr = File.CreateText("barat.txt"))
                {
                    for (int i = 0; i < 160; i++)
                    {
                        k = r.Next(1, 10);
                        wr.WriteLine("a {0},2001.02.10,F,{1}", i, k);
                    }
                }
            }
            //****************************************** Beolvasott filenak darabolása és listába rendezése *****************************************************************************
            using (StreamReader r = new StreamReader("barat.txt", Encoding.Default))
                while (r.EndOfStream == false)
                {
                    s = r.ReadLine();
                    if (s.Trim().Length == 0) continue; // üres sorok kiszűrése
                    ss = s.Split(',');

                    baratLista.Add(new BaratLapoz(
                        ss[0],
                        DateTime.Parse(ss[1]),
                        char.Parse(ss[2]),
                        int.Parse(ss[3])));
                }
        }
        //==================================================================== Lapozhatóságot biztosító metódus  =======================================================================================

        public void Kiir()
        {
            var page1 = baratLista.GetRange(0, 20);
            var page2 = baratLista.GetRange(20, 20);
            var page3 = baratLista.GetRange(40, 20);
            var page4 = baratLista.GetRange(60, 20);
            var page5 = baratLista.GetRange(80, 20);
            var page6 = baratLista.GetRange(100, 20);
            var page7 = baratLista.GetRange(120, 20);
            do
            {
                if (tovabb == 0)
                {
                    foreach (BaratLapoz key in page1)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 1)
                {
                    foreach (BaratLapoz key in page2)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 2)
                {
                    foreach (BaratLapoz key in page3)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 3)
                {
                    foreach (BaratLapoz key in page4)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 4)
                {
                    foreach (BaratLapoz key in page5)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 5)
                {
                    foreach (BaratLapoz key in page6)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 6)
                {
                    foreach (BaratLapoz key in page7)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == -1)
                {
                    Console.WriteLine("még 1 page up és a program kilép");
                }
                else if (tovabb == 7)
                {
                    Console.WriteLine("még 1 page down és a program kilép");
                }
                var gomb = Console.ReadKey(true);
                if (gomb.Key == ConsoleKey.PageDown)
                {
                    Console.Clear();
                    tovabb = tovabb + 1;
                }
                else if (gomb.Key == ConsoleKey.Home)
                {
                    Console.Clear();
                    tovabb = 0;
                }
                else if (gomb.Key == ConsoleKey.End)
                {
                    Console.Clear();
                    tovabb = 4;
                }
                else if (gomb.Key == ConsoleKey.PageUp)
                {
                    Console.Clear();
                    tovabb = tovabb - 1;
                }
                else { Console.Clear(); continue; }

            } while (tovabb > -2 && tovabb < 8);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaratLapoz baratLapoz = new BaratLapoz();
           
             
            baratLapoz.bekeres();
            baratLapoz.Kiir();
        }
    }
}


