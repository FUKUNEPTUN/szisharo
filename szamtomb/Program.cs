using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamtomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1000, //ami ennél kisebb
                max = -1, //ami ennel nagyobb 
                minIdx = 0, //legkisebb számnak indexe
                maxIdx = 0; // legnagyobb szám indexe
            int[] szam = new int[1000]; //létrehozom a tömb objektumot
            Random rna = new Random(); //létrehozok egy random objektumot

            for(int i = 0; i <= 99; i++) // feltöltöm a számokat a tömbbe
            {
                szam[i] = rna.Next(0, 1001); //0-1000ig generált számot generáltunk és a tömbbe beleteszem
            }
            for(int i = 0; i <=99; i++) // végig lépkedünk a tömb elemein, hogy megkeressem a legkisebb és legnagyobb elemét a tömbnek
            {
                if (szam[i] < min)  //ha tömb eleme kisebb mint min akkor..
                {
                    min = szam[i]; //elmentem az értéket a min változóba és...
                    minIdx = i;// min indexet a minIdx változóba
                }
                if (szam[i] > max)//ha tömb eleme nagyobb mint max akkor..
                {
                    max = szam[i];// elmentem az értéket a max változoba és..
                    maxIdx = i;//az aktuális indexet a maxIdx-be
                }
            }

            Console.WriteLine("Legkisebb érték, " + min +" indexe " + minIdx + " Legnagobb érték, " + max + " indexe "+ maxIdx); //az eredményt kiírattatom 
            Console.ReadKey();
            
        }
    }
}
