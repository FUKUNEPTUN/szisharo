using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varosnevek
{
    class Varos
    {
        List<string> parts = new List<string>();
        //Metódusok:
        //setDb:bekérjük hogy hány nevet akarunk eltárolni.Ha semmit vagy 0-át ír be a felhasználó, akkor a beolvasást addig folytatjuk, amíg üres mezőt nem ír be.
        //setNevek:Bekérük a neveket az előbb megadott módon beolvassuk és hozzáadjuk a listához
        //getNevek:kiiratjuk vesszővel elválasztva a letárolt neveket
        //getVan:Bekérünk egy nevet és kiirjuk hogy szerepel-e a listában
        //delNev: Bekérünk egy nevet.Ha szerepel a listában, akkor töröljük, ha nem, akkor hozzáadjuk.
        //delLast:kitörli a listában lévő utolsó elemet

        public Varos() { }
        int beolvasSzam;
        string beolvas, beolvasVaros;
        bool folyt;
        public void setDb()
        {
                folyt = false;
                Console.WriteLine("Hány várost tároljunk el?");
                beolvas = Console.ReadLine();
                if (beolvas == "0" || beolvas == "" || beolvas == " ")
                {
                    folyt = true;
                }
                else
                {
                    this.beolvasSzam = Convert.ToInt32(beolvas);
                }
        }
        public void setNevek()
        {
            if (folyt)
            {
                do
                {
                    folyt = true;
                    Console.WriteLine("Adja meg a város nevet");
                    beolvasVaros = Console.ReadLine();
                    if (beolvasVaros == "0" || beolvasVaros == "" || beolvasVaros == " ")
                    {
                        folyt = false;
                    }
                    else
                    {
                        parts.Add(beolvasVaros);
                    }
                } while (folyt);
            }
            else
            {
                for (int i = 0; i < beolvasSzam; i++)
                {
                    Console.WriteLine("Adja meg a város nevet (ennyit fogunk beolvasni: {0})",beolvasSzam);
                    beolvasVaros = Console.ReadLine();
                    parts.Add(beolvasVaros);
                }
            }

            

        }
        public void getNevek()
        {
            for (int i = 0; i < parts.Count; i++)
            {
                Console.Write("{0},", parts[i]);
            }

        }
        public void getVan()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Adja meg a keresendő város nevet");
            beolvasVaros = Console.ReadLine();
            bool szerepel = false;
            for (int i = 0; i < parts.Count; i++)
            {
                if (beolvasVaros == parts[i])
                {
                    szerepel = true;
                }
                else
                {
                }
            }
            if (szerepel)
            {
                
                Console.WriteLine("Ez a város név szerepel az adatbázisunkban");
            }
            else
            {

                Console.WriteLine("Ez a város még nem szerepelt");
            }

        }
        public void delNev()
        {

            Console.WriteLine("Adja meg a kitörlendő városnak nevet");
            beolvasVaros = Console.ReadLine();
            bool nincs= false;
            int count = 0;
            for (int i = 0; i < parts.Count; i++)
            {
                if (beolvasVaros == parts[i])
                {
                    
                    count = i;
                    nincs = true;

                }
            }




            if (nincs)
            {
                parts.RemoveAt(count);
            }
            else
            {

                parts.Add(beolvasVaros);
            }







            Console.WriteLine("DelNev metódus eredménye");


            for (int i = 0; i < parts.Count; i++)
            {
                Console.Write("{0},", parts[i]);
            }
        }


        public void delLast(){

            parts.RemoveAt(parts.Count - 1);
            Console.WriteLine(" ");
            Console.WriteLine("Dellast metódus eredménye");
            for (int i = 0; i < parts.Count; i++)
            {
                Console.Write("{0},", parts[i]);
            }
        }

}
    class Program
    {
        static void Main(string[] args)
        {
            Varos varos = new Varos();
            varos.setDb();
            varos.setNevek();
            varos.getNevek();
            varos.getVan();
            varos.delNev();
            varos.delLast();
            Console.ReadLine();
        }
    }
}
