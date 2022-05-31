using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxUt
{
     public class MyClass
    {
        int min = 1000; // Minimum megadása
        int max = 0; // Maximum megadása
        int minInd = 0; // A kiválasztott minimum indexe
        int maxInd = 0; // A kiválasztott maximum indexe
        int i; // A tömb egy pillanatnyi indexe

        int[] tomb = new int[100]; // Tömb meghatározása és a terület lefoglalása neki
        Random veletlen = new Random(); // Random generálás
        public MyClass()
        {
            feltoltes();
        }
        public MyClass(int a)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = i+1;
            }

        }
        private void feltoltes()
        {
            for (i = 0; i < tomb.Length; i++) // Végigmegy a tömb indexein miközben feltölti azokat
            {
                tomb[i] = veletlen.Next(0, 10000); // Random generálás megadott tartományok között
            }
         
        }
        public void kaka()
        {
            for (i = 0; i < tomb.Length; i++) // Végigmegy a tömb elemein a megadott határig (i < 50 => 50 elemen)
            {
                //Console.WriteLine(tomb[i]);
                if (tomb[i] < min)
                {
                    min = tomb[i];
                    minInd = i;
                }
                else if (tomb[i] > max)
                {
                    max = tomb[i];
                    maxInd = i;
                }
            }
            Console.WriteLine("A minimum szám: {0}, helye: {1} || A maximum szám: {2}, helye: {3}", min, minInd, max, maxInd);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1);
            
            myClass.kaka();
            Console.ReadKey();
        }

    }
}
