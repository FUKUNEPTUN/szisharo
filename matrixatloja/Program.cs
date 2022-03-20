using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixatlo
{
    class Matrix
    {
        private int ertek,
            atlo_a,
            atlo_b,
            egyikatlo,
            masikatlo;
        private int[,] matrix;

        public Matrix()
        {
            this.egyikatlo = atlo_a;
            this.masikatlo = atlo_b;
        }

        Random rand = new Random();

        public void MatrixFeltoltes()
        {
            Console.WriteLine("Adja meg a mátrix nagyságát:");
            ertek = int.Parse(Console.ReadLine());
            matrix = new int[ertek, ertek];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0, 100);
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void aAtlo()
        {
            int osszeg = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                osszeg = osszeg + matrix[i, i];
            }
            if (matrix.GetLength(0) % 2 != 0)
            {
                osszeg = osszeg - matrix[matrix.GetLength(0) / 2 + 1, matrix.GetLength(0) / 2 + 1];
            }
            for (int j = ertek; j < matrix.GetLength(0); j--)
            {
                osszeg = osszeg + matrix[j, j];
            }
            Console.WriteLine(osszeg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix();
            a.MatrixFeltoltes();
            a.aAtlo();
            Console.ReadKey();
        }
    }
}