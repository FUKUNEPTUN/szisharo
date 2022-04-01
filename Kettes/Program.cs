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
        {
            Console.WriteLine("add meg a váltani kívánt számod");
            szam = Convert.ToInt32(Console.ReadLine());
            a = szam;
            szamrendszer = 2;
            Console.WriteLine("*********************************");
            Console.WriteLine("\t{0}\t||\t{1}\t", szam, szamrendszer);
            Console.WriteLine("*********************************");
            while (szam > 0)
            {
                
                maradek = szam % szamrendszer;
                szam = szam / szamrendszer;
                Console.WriteLine("\t{0}\t||\t{1}\t", szam, maradek);
                ere.Add(maradek);
            }
            Console.Write("{0} kettes számrendszerbeli értéke:  \t",a);
            for (int i = ere.Count-1; i >= 0; i--) 
            {
            Console.Write(ere[i]);
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
