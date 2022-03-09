using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor
{
    class Vektor
    {
        // Osztályváltozók
        protected int elemekszama;
        private int ertek,
            ertek2,
            atlagertek,
            atlagertek2,
            min,
            min2,
            max,
            max2,
            minimumIndex,
            minimumIndexSor,
            minimumIndexOszlop,
            maximumIndex,
            maximumIndexSor,
            maximumIndexOszlop;
        private int[] vektorhossz;

        // Random szám generálás

        Random rand = new Random();

        public Vektor() { }

        public void Feltoltes()
        {
            Console.WriteLine("Írja be a vektor hosszát:");
            elemekszama = int.Parse(Console.ReadLine());
            vektorhossz = new int[elemekszama];
            for (int i = 0; i < elemekszama; i++)
            {
                vektorhossz[i] = rand.Next(0, 100);
            }
        }

        public void setOsszeg()
        {
            int osszeg = 0;
            for (int i = 0; i < vektorhossz.Length; i++)
            {
                osszeg = osszeg + vektorhossz[i];
            }
            this.ertek = osszeg;
        }

        public int getOsszeg()
        {
            Console.WriteLine("Az összeg: {0}", this.ertek);
            return this.ertek;
        }

        public void setFindAtlag()
        {
            int atlag;
            atlag = this.ertek / vektorhossz.Length;
            this.atlagertek = atlag;
        }

        public double getFindAtlag()
        {
            Console.WriteLine("Az átlag: {0}", this.atlagertek);
            return this.atlagertek;
        }

        public void setMinimum()
        {
            int minimum,
                minindex = 0;
            minimum = vektorhossz.Min();
            this.min = minimum;
            for (int i = 0; i < vektorhossz.Length; i++)
            {
                if (vektorhossz[i] == minimum)
                {
                    minindex = i;
                }
            }
            this.minimumIndex = minindex;
        }

        public int getMinimum()
        {
            Console.WriteLine("A legkisebb elem: {0}, helye: {1}", this.min, this.minimumIndex);
            return this.min;
        }

        public void setMaximum()
        {
            int maximum,
                maxindex = 0;
            maximum = vektorhossz.Max();
            this.max = maximum;
            for (int i = 0; i < vektorhossz.Length; i++)
            {
                if (vektorhossz[i] == maximum)
                {
                    maxindex = i;
                }
            }
            this.maximumIndex = maxindex;
        }

        public int getMaximum()
        {
            Console.WriteLine("A legnagyobb elem: {0}, helye: {1}", this.max, this.maximumIndex);
            return this.max;
        }

        class Matrix : Vektor
        {
            // Osztályváltozók
            private int[,] vektornakhossza;

            public Matrix() : base() { }

            public void matrixFel()
            {
                Console.WriteLine("Adja meg a mátrix nagyságát:");
                elemekszama = int.Parse(Console.ReadLine());
                vektornakhossza = new int[elemekszama, elemekszama];
                for (int i = 0; i < elemekszama; i++)
                {
                    for (int j = 0; j < elemekszama; j++)
                    {
                        vektornakhossza[i, j] = rand.Next(0, 100);
                        Console.Write("{0,4}", vektornakhossza[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            public void setOsszes()
            {
                int osszes = 0;
                for (int i = 0; i < vektornakhossza.GetLength(0); i++)
                {
                    for (int j = 0; j < vektornakhossza.GetLength(1); j++)
                    {
                        osszes = osszes + vektornakhossza[i, j];
                    }
                    this.ertek2 = osszes;
                }
            }

            public int getOsszes()
            {
                Console.WriteLine("Az összeg: {0}", this.ertek2);
                return this.ertek2;
            }

            public void setMatrixAtlag()
            {
                int atlag;
                atlag = this.ertek2 / vektornakhossza.Length;
                this.atlagertek2 = atlag;
            }

            public double getMatrixAtlag()
            {
                Console.WriteLine("Az átlag: {0}", this.atlagertek2);
                return this.atlagertek2;
            }

            public void setMatrixMin()
            {
                int minimum,
                    minindexSor = 0,
                    minindexOszlop = 0;
                minimum = vektornakhossza.Cast<int>().Min();
                this.min2 = minimum;
                bool kilep = false;
                for (int i = 0; i < vektornakhossza.GetLength(0); i++)
                {
                    for (int j = 0; j < vektornakhossza.GetLength(1); j++)
                    {
                        if (vektornakhossza[i, j] == minimum)
                        {
                            kilep = true;
                            minindexSor = i;
                            minindexOszlop = j;
                            break;
                        }
                    }
                    if (kilep)
                    {
                        break;
                    }
                }
                this.minimumIndexSor = minindexSor;
                this.minimumIndexOszlop = minindexOszlop;
            }

            public int getMatrixMin()
            {
                Console.WriteLine("A legkisebb elem: {0}, helye: {1}, {2}", this.min2, this.minimumIndexSor, this.minimumIndexOszlop);
                return this.min2;
            }

            public void setMatrixMax()
            {
                int maximum,
                    maxindexsor = 0,
                    maxindexoszlop = 0;
                maximum = vektornakhossza.Cast<int>().Max();
                this.max2 = maximum;
                bool kilep = false;
                for (int i = 0; i < vektorhossz.GetLength(0); i++)
                {
                    for (int j = 0; j < vektornakhossza.GetLength(1); j++)
                    {
                        if (vektornakhossza[i, j] == maximum)
                        {
                            kilep = true;
                            maxindexsor = i;
                            maxindexoszlop = j;
                            break;
                        }
                    }
                    if (kilep)
                    {
                        break;
                    }
                }
                this.maximumIndexSor = maxindexsor;
                this.maximumIndexOszlop = maxindexoszlop;
            }

            public int getMatrixMax()
            {
                Console.WriteLine("A legnagyobb elem: {0}, helye: {1}, {2}", this.max2, this.maximumIndexSor, this.maximumIndexOszlop);
                return this.max2;
            }

            class Program
            {
                static void Main(string[] args)
                {
                    Matrix a = new Matrix();
                    a.Feltoltes();
                    a.setOsszeg();
                    a.getOsszeg();
                    a.setFindAtlag();
                    a.getFindAtlag();
                    a.setMinimum();
                    a.getMinimum();
                    a.setMaximum();
                    a.getMaximum();
                    a.matrixFel();
                    a.setOsszes();
                    a.getOsszes();
                    a.setMatrixAtlag();
                    a.getMatrixAtlag();
                    a.setMatrixMin();
                    a.getMatrixMin();
                    a.setMatrixMax();
                    a.getMatrixMax();
                    Console.ReadKey();
                }
            }
        }
    }
}