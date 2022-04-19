using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix4
{
    class Matrix
    {
        private int sorok, k, oszlopok, szamol = 0;
        private int[,] matrix;
        private string folyt = "i";
        public Matrix()
        {


        }
        public void Bekr()
        {
            Console.WriteLine("Adja meg a sorok számát");
            sorok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a oszlopok számát");

            oszlopok = Convert.ToInt32(Console.ReadLine());
            matrix = new int[sorok, oszlopok];
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    matrix[i, j] = 0;
                    szamol++;
                }
            }
            Console.WriteLine("Adja meg a 3 számot");
            do
            {
                string[] ertek = Console.ReadLine().Split(',');
                int sor = Convert.ToInt32(ertek[0]), oszlop = Convert.ToInt32(ertek[1]), csere = Convert.ToInt32(ertek[2]);
                if (matrix[sor, oszlop] == 0)
                {
                    matrix[sor, oszlop] = csere; szamol--;
                }
                else { Console.WriteLine("ezen az indexen már állt egy érték"); }
                Console.WriteLine("Kívánja folytatni? (i/n)");
                folyt = Console.ReadLine();
                if (folyt != "i")
                {

                    Console.WriteLine("NEM válasz érkezett, pedig {0} helyet feltöltetlenül hagytál. Folytassuk?(i/n)", szamol);
                    folyt = Console.ReadLine();

                }
            } while (folyt == "i");
            Console.Clear();


        }
        public void Kiolv()
        {
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    Console.Write("{0}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.Bekr();
            matrix.Kiolv();
            Console.ReadKey();
        }
    }
}
