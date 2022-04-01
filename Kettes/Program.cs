using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes
{
    class Kettes
    {
        int szam,a, szamrendszer, maradek;
        List<int> ere = new List<int>();
       
        public Kettes() { }
        public void szeru()
        { //bekérjük számot
            Console.WriteLine("add meg a váltani kívánt számod");
            szam = Convert.ToInt32(Console.ReadLine());
            a = szam; //bekért szám elmentése későbbre, mert az a változó amiben eredetileg van, később felül lesz írva
            szamrendszer = 2;
            Console.WriteLine("*********************************");
            Console.WriteLine("\t{0}\t||\t{1}\t", szam, szamrendszer);
            Console.WriteLine("*********************************");
            while (szam > 0)
            {
                maradek = szam % szamrendszer; // csak ez kell nekünk
                szam = szam / szamrendszer;// ez szorgalmi
                Console.WriteLine("\t{0}\t||\t{1}\t", szam, maradek);
                ere.Add(maradek);//maradék hozzáadása a listánkhoz
            }
            Console.Write("{0} kettes számrendszerbeli értéke:  \t",a);
            for (int i = ere.Count-1; i >= 0; i--) 
            {
            Console.Write(ere[i]);//lista kiír
            }

            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kettes nagy = new Kettes();
            nagy.szeru();
            Console.ReadLine();
        }
    }
}
