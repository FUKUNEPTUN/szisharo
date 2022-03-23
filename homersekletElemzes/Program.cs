using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homersekletElemzes
{
    class Program
    {
        static void Main(string[] args)
        {
            int januarMin = 100, januarMax = -100,
                febMin = 100, febMax = -100,
                marMin = 100, marMax = -100,
                aprMin = 100, aprMax = -100,
                majMin = 100, majMax = -100,
                junMin = 100, junMax = -100,
                julMin = 100, julMax = -100,
                augMin = 100, augMax = -100,
                szepMin = 100, szepMax = -100,
                oktMin = 100, oktMax = -100,
                novMin = 100, novMax = -100,
                decMin = 100, decMax = -100,
                telMin = 100, telMax = -100,
                tavMin = 100, tavMax = -100,
                nyarMin = 100, nyarMax = -100,
                oszMin = 100, oszMax = -100,
                dateh = 0, daten = 0;
            double honapAtlag = 0, telAtlag = 0, tavaszAtlag = 0, nyarAtlag = 0, oszAtlag = 0,
                janAtlag = 0,
                febAtlag = 0,
                marAtlag = 0,
                aprAtlag = 0,
                majAtlag = 0,
                junAtlag = 0,
                julAtlag = 0,
                augAtlag = 0,
                szepAtlag = 0,
                decAtlag = 0,
                oktAtlag = 0,
                novAtlag = 0;
            int[,] tel = new int[3, 30];
            int[,] tavasz = new int[3, 30];
            int[,] nyar = new int[3, 30];
            int[,] osz = new int[3, 30];
            Random rnd = new Random();


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    tel[i, j] = rnd.Next(-20, 18);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    tavasz[i, j] = rnd.Next(-2, 18);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    nyar[i, j] = rnd.Next(15, 40);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    osz[i, j] = rnd.Next(0, 25);
                }
            }
            //for (int i = 0; i < 1; i++)
            //{
            //    for (int j = 0; j < 30; j++)
            //    {
            //        Console.WriteLine("index {0}-----Hőmerseklet{1}", j, tel[0, j]);
            //    }
            //}

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (tel[i, j] > telMax)
                    {
                        telMax = tel[i, j];
                    }

                    if (tel[i, j] < telMin)
                    {
                        telMin = tel[i, j];
                    }
                    telAtlag = Math.Round((telAtlag + tel[i, j]) / 90, 2);
                }

            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (tel[i, j] > januarMax)
                    {
                        januarMax = tel[i, j];
                    }

                    if (tel[i, j] < januarMin)
                    {
                        januarMin = tel[i, j];
                    }
                    janAtlag = Math.Round((janAtlag + tel[i, j]) / 30, 2);
                }
            }
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (tel[i, j] > febMax)
                    {
                        febMax = tel[i, j];
                    }

                    if (tel[i, j] < febMin)
                    {
                        febMin = tel[i, j];
                    }
                    febAtlag = Math.Round((febAtlag + tel[i, j]) / 30, 2);
                }
            }
            for (int i = 2; i != 3; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (tel[i, j] > decMax)
                    {
                        decMax = tel[i, j];
                    }

                    if (tel[i, j] < decMin)
                    {
                        decMin = tel[i, j];
                    }
                    decAtlag = Math.Round((decAtlag + tel[i, j]) / 30, 2);
                }
            }








            Console.WriteLine("adja meg a hónapot");
            dateh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("adja meg a adja meg a napot");
            daten = Convert.ToInt32(Console.ReadLine());
            switch (dateh)
            {

                case 1:

                    Console.WriteLine("Legmelegebb nap az idei télen    {0}  || Leghidegebb nap az idei télen {2} || Átlag hőmérséklet télen {1}", telMax, janAtlag, telMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a januárban    {0}  || Leghidegebb nap januárban {1} || Átlag hőmérséklet januárban {2}", januarMax, januarMin, janAtlag);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("{1}.{2}   Napi hőmérséklet  {0}", tel[0, daten-1],dateh,daten);
                    break;
                case 2:

                    Console.WriteLine("Legmelegebb nap az idei télen    {0}  || Leghidegebb nap az idei télen {2} || Átlag hőmérséklet télen {1}", telMax, telAtlag, telMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a februárban    {0}  || Leghidegebb nap februárban {1} || Átlag hőmérséklet februárban {2}", febMax, febMin, febAtlag);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Napi hőmérséklet  {0}", tel[0, daten - 1]);
                    break;
                case 3:

                    Console.WriteLine("Legmelegebb nap az idei tavasszal    {0}  || Leghidegebb nap az idei tavasszal {2} || Átlag hőmérséklet tavasszal {1}", tavMax, tavaszAtlag, tavMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a januárban    {0}  || Leghidegebb nap januárban {1} || Átlag hőmérséklet januárban {2}", januarMax, januarMin, janAtlag);
                    Console.WriteLine("=========================================================================================================");
                    break;
                case 4:

                    Console.WriteLine("Legmelegebb nap az idei tavasszal    {0}  || Leghidegebb nap az idei tavasszal {2} || Átlag hőmérséklet tavasszal {1}", tavMax, tavaszAtlag, tavMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a januárban    {0}  || Leghidegebb nap januárban {1} || Átlag hőmérséklet januárban {2}", majMax, majMin, majAtlag);
                    Console.WriteLine("=========================================================================================================");
                    break;
                case 5:

                    Console.WriteLine("Legmelegebb nap az idei tavasszal    {0}  || Leghidegebb nap az idei tavasszal {2} || Átlag hőmérséklet tavasszal {1}", tavMax, tavaszAtlag, tavMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a januárban    {0}  || Leghidegebb nap januárban {1} || Átlag hőmérséklet januárban {2}", majMax, majMin, majAtlag);
                    Console.WriteLine("=========================================================================================================");
                    break;
                case 6:

                    Console.WriteLine("Legmelegebb nap az idei nyáron    {0}  || Leghidegebb nap az idei nyáron {2} || Átlag hőmérséklet nyáron {1}", nyarMax, nyarAtlag, nyarMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a januárban    {0}  || Leghidegebb nap januárban {1} || Átlag hőmérséklet januárban {2}", junMax, junMin, junAtlag);
                    Console.WriteLine("=========================================================================================================");
                    break;
                case 7:

                    Console.WriteLine("Legmelegebb nap az idei nyáron    {0}  || Leghidegebb nap az idei nyáron {2} || Átlag hőmérséklet nyáron {1}", nyarMax, nyarAtlag, nyarMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a januárban    {0}  || Leghidegebb nap januárban {1} || Átlag hőmérséklet januárban {2}", julMax, julMin, julAtlag);
                    Console.WriteLine("=========================================================================================================");
                    break;
                case 8:

                    Console.WriteLine("Legmelegebb nap az idei nyáron    {0}  || Leghidegebb nap az idei nyáron {2} || Átlag hőmérséklet nyáron {1}", nyarMax, nyarAtlag, nyarMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a augusztusban    {0}  || Leghidegebb nap augusztusban {1} || Átlag hőmérséklet augusztusban {2}", augMax, augMin, augAtlag);
                    Console.WriteLine("=========================================================================================================");
                    break;
                case 9:

                    Console.WriteLine("Legmelegebb nap az idei ősszel    {0}  || Leghidegebb nap az idei ősszel {2} || Átlag hőmérséklet ősszel {1}", oszMax, oszAtlag, oszMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a januárban    {0}  || Leghidegebb nap januárban {1} || Átlag hőmérséklet januárban {2}", szepMax, szepMin, szepAtlag);
                    Console.WriteLine("=========================================================================================================");
                    break;
                case 10:

                    Console.WriteLine("Legmelegebb nap az idei ősszel    {0}  || Leghidegebb nap az idei ősszel {2} || Átlag hőmérséklet ősszel {1}", oszMax, oszAtlag, oszMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a októberben    {0}  || Leghidegebb nap októberben {1} || Átlag hőmérséklet októberben {2}", oktMax, oktMin, oktAtlag);
                    Console.WriteLine("=========================================================================================================");
                    break;
                case 11:

                    Console.WriteLine("Legmelegebb nap az idei ősszel    {0}  || Leghidegebb nap az idei ősszel {2} || Átlag hőmérséklet ősszel {1}", oszMax, oszAtlag, oszMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a novemberben    {0}  || Leghidegebb nap novemberben {1} || Átlag hőmérséklet novemberben {2}", novMax, novMin, novAtlag);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Napi hőmérséklet  {0}", osz[0, daten - 1]);
                    break;
                case 12:

                    Console.WriteLine("Legmelegebb nap az idei télen    {0}  || Leghidegebb nap az idei télen {2} || Átlag hőmérséklet télen {1}", telMax, telAtlag, telMin);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Legmelegebb nap a decemberben    {0}  || Leghidegebb nap decemberben {1} || Átlag hőmérséklet decemberben {2}", decMax, decMin, decAtlag);
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Napi hőmérséklet  {0}", tel[0, daten - 1]);
                    break;
            }

            Console.ReadLine();
        }
    }
}



