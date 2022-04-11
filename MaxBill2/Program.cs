using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill
{
    class Program
    {
        class Matrix
        {
            protected int a, b;
            protected int[,] matric;
            public Matrix() { }
            public virtual void varázsló()
            {
                Console.WriteLine("Hány  legyen a mátrix?");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Hány  legyen a mátrix?");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Kérlek add meg az elemeket!");
                matric = new int[a, b];
                for (int i = 0; i < matric.GetLength(0); i++)
                {
                    for (int j = 0; j < matric.GetLength(1); j++)
                    {
                        Console.Write("Kérem a(z) {0} sor {1} oszlopa elemet: ", i + 1, j + 1);
                        matric[i, j] = int.Parse(Console.ReadLine());
                    }
                }


                Console.WriteLine("Mátrix elemeinek kiírása\n==========================");
                for (int x = 0; x < a; x++)
                {
                    for (int d = 0; d < b; d++)
                    {
                        Console.Write("{0} ", matric[x, d]);
                    }
                    Console.WriteLine();
                }
            }
        }
        class Puki : Matrix
        {
            public Puki() { }
            public override void varázsló()
            {
                Console.WriteLine("Sorok száma");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Oszlopok száma");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Kérlek add meg az elemeket!");
                matric = new int[a, b];
                for (int i = 0; i < matric.GetLength(0); i++)
                { 
                    for (int j = 0; j < matric.GetLength(1); j++)
                    {
                       
                        Console.Write("Kérem adja meg ennek az indexnek elemét {0} // {1}  : ", i, j);
                        matric[i, j] = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();
                    Console.WriteLine(" Sor Elemei ");
                    for (int k = 0; k < matric.GetLength(1); k++)
                    {
                        
                        Console.Write(matric[i, k] + " ");
                    }
                    Console.WriteLine("\n************************");
                }
            }
        }
        static void Main(string[] args)
        {
            Puki tűz = new Puki();
            tűz.varázsló();
            Console.ReadKey();
        }
    }
}