using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Palindrom
    {
        
        string beolvas;
        char[] tomb1;
        char[] tomb2;
        bool alak = true;
        public Palindrom() { }
        public void pabaji()
        {
            //

            Console.WriteLine("Írd be a szöveget");
            beolvas = Console.ReadLine();//szöveg beolvas
            Console.Clear(); // amit a felhasználó beírt szöveg, annak törlése, hogy az időközben lefutó tesztek, ellenőrzések átláthatóbbak legyeneke
            Console.WriteLine(beolvas);
            beolvas = beolvas.ToUpper();//Nagybetűvé alakítás
            Console.WriteLine(beolvas);
            beolvas = beolvas.Replace("."," ");//zavaró karakterek kiszedése, 2 vagy több karakterből álló betűk semlegesítése
            beolvas = beolvas.Replace(",", " ");
            beolvas = beolvas.Replace("?", " ");
            beolvas = beolvas.Replace(":", " ");
            beolvas = beolvas.Replace("!", " ");
            beolvas = beolvas.Replace("-", " ");
            beolvas = beolvas.Replace("Í", "I");
            beolvas = beolvas.Replace("Ó", "O");
            beolvas = beolvas.Replace("Ő", "Ö");
            beolvas = beolvas.Replace("U", "Ú");
            beolvas = beolvas.Replace("Ü", "Ű");
            beolvas = beolvas.Replace("CS", "CCC");
            beolvas = beolvas.Replace("DZ", "DDD");
            beolvas = beolvas.Replace("DZS", "DDDD");
            beolvas = beolvas.Replace("GY", "GG");
            beolvas = beolvas.Replace("DJ", "GG");
            beolvas = beolvas.Replace("LY", "J");
            beolvas = beolvas.Replace("NY", "NN");
            beolvas = beolvas.Replace("SZ", "SSS");
            beolvas = beolvas.Replace("TY", "YYY");
            beolvas = beolvas.Replace("ZS", "SSS");
            Console.WriteLine(beolvas);
            beolvas = String.Concat(beolvas.Where(c => !Char.IsWhiteSpace(c)));//szóközök kiszedése
            Console.WriteLine(beolvas);
            tomb2 = beolvas.ToCharArray();
            tomb1 = new char[beolvas.Length];
            for (int i = 0; i < tomb2.Length; i++)
            {
                tomb1[i] = tomb2[i];
            }
            Array.Reverse(tomb1);//a szöveg megfordítsa
            for (int i = 0; i < tomb1.Length; i++)
            {
                Console.Write(tomb1[i]);
            }
            Console.WriteLine(" ");
            //for (int j = tomb2.Length - 1; j >= 0; j--) 
            //{
            //    tomb1[i] = tomb2[j];
            //     i++;
            //}
            if (tomb1.Length == tomb2.Length)
            {

                for (int i = 0; i < tomb2.Length; i++)
                {//amíg a karakterek megegyeznek true értéke van
                    if (tomb2[i] != tomb1[i])
                    {
                        //ha nem egyeznek meg, akkor false
                        alak = false;
                    }
                }
            }
            else
            {

                alak = false;
            }
            //végül ha maradt true akkor kiírja ezt:
            if (alak)
            {
                Console.WriteLine("Ez egy palindrom szöveg");

            }
            //ha időközben valamiben eltért a 2 tömb és false lett az eredmény akkor kiírja ezt:
            else
            {
                Console.WriteLine("Ez nem egy palindrom szöveg");

            }





        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrom fortinajtiala = new Palindrom();
            fortinajtiala.pabaji();
            Console.ReadKey();  
        }
    }
}
