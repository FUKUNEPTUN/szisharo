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
        int i = 0;
        public Palindrom() { }
        public void pabaji()
        {
            beolvas = Console.ReadLine();//szöveg beolvas
            Console.Clear(); // amit a felhasználó beírt szöveg, annak törlése, hogy az időközben lefutó tesztek, ellenőrzések átláthatóbbak legyeneke
            Console.WriteLine(beolvas);
            beolvas = beolvas.ToUpper();//Nagybetűvé alakítás
            Console.WriteLine(beolvas);
            beolvas = beolvas.Replace("."," ");//zavaró karakterek kiszedése
            beolvas = beolvas.Replace(",", " ");
            beolvas = beolvas.Replace("?", " ");
            beolvas = beolvas.Replace("!", " ");
            Console.WriteLine(beolvas);
            beolvas = String.Concat(beolvas.Where(c => !Char.IsWhiteSpace(c)));//szóközök kiszedése
            Console.WriteLine(beolvas);
            tomb2 = beolvas.ToCharArray();
            tomb1 = new char[beolvas.Length];
                for (int j = tomb2.Length - 1; j >= 0; j--) //a szöveg megfordítsa
                {
                    tomb1[i] = tomb2[j];
                     i++;
                }
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
