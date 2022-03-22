using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homersekletElemzes
{
    //class Homer
    //{ 
    //    private string[] evszakok = new string[4] { "tél", "tavasz", "nyár","ősz"};
    //    private string evszak, honap;

    //    private string[] honapok = new string[12] { "Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December" };
    //    private Random rnd = new Random();


    //    public void bekeres() {
    //        Console.WriteLine();
    //    }
    //    public void datum()
    //    {

    //        if(Console.ReadLine() == "januar")
    //        {


    //        }
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tel = new int[3,30];
            int[,] tavasz = new int[3,30];
            int[,] nyar = new int[3,30];
            int[,] osz = new int[3,30];
            Random rnd = new Random();


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                tel[i,j] = rnd.Next(-12, 15);
                }
            }
            //for (int i = 0; i < tavasz.Length; i++)
            //{
            //    for (int j = 0; j < tavasz.Length; j++)
            //    {
            //        tavasz[i, j] = rnd.Next(-2, 18);
            //    }
            //}
            //for (int i = 0; i < nyar.Length; i++)
            //{
            //    for (int j = 0; j < nyar.Length; j++)
            //    {
            //        nyar[i, j] = rnd.Next(15, 40);
            //    }
            //}
            //for (int i = 0; i < osz.Length; i++)
            //{
            //    for (int j = 0; j < osz.Length; j++)
            //    {
            //        osz[i, j] = rnd.Next(0, 25);
            //    }
            //}
            for (int i = 0; i < 3; i++)
            {
                for (int j = 20; j < 30; j++)
                {
                    Console.WriteLine("index {0}-----Hőmerseklet{1}",j,tel[1, j]);
                }
            }

            Console.ReadLine();
        }
    }
}



