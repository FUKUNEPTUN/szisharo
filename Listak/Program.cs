using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Zero
    {
        Random random = new Random();
        public Zero() { }
        public void vs()
        {
            Console.WriteLine("Hány elemű legyen a lista?"); 
            
            int[] lista = new int[Convert.ToInt32(Console.ReadLine())];
            Console.Clear();
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = random.Next(10,100);
            }

            Console.WriteLine("Index:\t\t||\tindexen álló érték: ");

            Console.WriteLine("*******************************************");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("\t {0}\t||\t {1}", i,lista[i]);
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zero zero = new Zero();
            zero.vs();
            Console.ReadKey();
        }
    }
}
