using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halmazok
{
    class Halmazok
    {
        private int[] A, B;
        private int elemszamA, elemszamB;
        private char key;
        private Random rdm = new Random();
        public Halmazok(int[] A, int[] B, int elemszamA, int elemszamB)
        {
            this.A = A;
            this.B = B;
            this.elemszamA = elemszamA;
            this.elemszamB = elemszamB;
        }
        public Halmazok() { }
        public void feltoltA()
        {
            Console.WriteLine("Írd be az elemek számát az első halmazban!");
            elemszamA = int.Parse(Console.ReadLine());
            if (elemszamA > 200) { elemszamA = rdm.Next(100, 200); }
            A = new int[elemszamA];
            for (int i = 0; i < elemszamA; i++) { A[i] = rdm.Next(-100, 100); /*Console.WriteLine("{0}",A[i]);*/}

        }
        public int[] feltoltB_x() { return this.B; }
        public int[] feltoltA_x() { return this.A; }
        public void feltoltB()
        {
            Console.WriteLine("Írd be az elemek számát a második halmazban!");
            elemszamB = int.Parse(Console.ReadLine());
            if (elemszamB > 200) { elemszamB = rdm.Next(100, 200); }
            B = new int[elemszamB];
            for (int i = 0; i < elemszamB; i++) { B[i] = rdm.Next(-100, 100); /*Console.WriteLine("{0}",B[i]);*/}
        }
        public void valasz()
        {
            Console.WriteLine("Kérlek add meg, hogy melyik műveletet végezzük el!:\nu = Unió\nm = Metszet\na = A-B\nb = B-A\n");
            key = Console.ReadKey().KeyChar;
            if (key == 'u') // Unió
            {
                IEnumerable<int> unio = feltoltA_x().Union(feltoltB_x());
                Console.WriteLine("\nA 2 halmaz uniójába tartozó számok: ");
                foreach (int un in unio) { Console.Write("{0} ", un); }
            }
            else if (key == 'm') // Metszet
            {
                int n = elemszamA; //a tömb mérete
                int m = elemszamB; //b tömb mérete
                int o = n + m;
                int[] metszet = new int[o];
                int j;
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    j = 0;
                    while (j < m && feltoltB_x()[j] != feltoltA_x()[i]) { j++; }
                    if (j < m)
                    {
                        metszet[k] = feltoltA_x()[i];
                        k++;
                    }
                }
                o = k;
                for (int i = 0; i < o; i++)
                {
                    if (metszet == null)
                    {
                        Console.Write("\nSajnos nincs a 2 tömb metszetében egy szám sem.");
                    }
                    else
                    {
                        Console.Write("\nA 2 tömb metszete: \n{0}", metszet[i]);
                    }
                }

            }
            else if (key == 'a') // A halmazból B halmaz
            {
                IEnumerable<int> ab = feltoltA_x().Except(feltoltB_x());
                Console.WriteLine("\nA 2 halmaz külömbsége (A-B) ");
                foreach (int aa in ab) { Console.Write("{0} ", aa); }
            }
            else if (key == 'b') // B halmazból A halmaz
            {
                IEnumerable<int> bb = feltoltB_x().Except(feltoltA_x());
                Console.WriteLine("\nA 2 halmaz külömbsége (B-A) ");
                foreach (int ba in bb) { Console.Write("{0} ", ba); }
            }
            else
            { Console.WriteLine("\nKérlek a felsorolt karakterek közül egyet adj meg!"); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Halmazok megoldas = new Halmazok();
            megoldas.feltoltA();
            megoldas.feltoltB();
            megoldas.valasz();
            Console.ReadKey();
        }
    }
}
