using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill
{
    class Matrix
    {
        int[,] matric;
        Random rnd = new Random();
        public Matrix() { }
        public void us()
        {
            Console.WriteLine("Add meg az oszlopok számát");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg az sorok számát");
            int b = Convert.ToInt32(Console.ReadLine());
            matric = new int[b, a];
            for (int i = 0; i < b; i++)
            {

                for (int j = 0; j < a; j++)
                {

                    Console.Write("\t");
                    matric[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A beírt érték ide került:");
                    Console.WriteLine("oszlop index {0}  sor index {1}", i, j);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------");


                }
            }

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("{0} ", matric[i, j]);

                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix among = new Matrix();
            among.us();
            Console.ReadKey();
        }
    }
}
