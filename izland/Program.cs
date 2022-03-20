using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szigetek
{
    class Program
    {
        static void Main(string[] args)
        {
            //string data = "11111011110100110011101111100000001010111101010011"; //Ha nem bekéréssel csináljuk
            Console.WriteLine("Add még az értékeket! (0/1)");
            string data = Console.ReadLine();
            int islandCount = 0,
                maxIslandLength = 0,
                i = 0;
            while (i < data.Length)
            {
                if (data[i] == '1')
                {
                    ++islandCount;
                    int j = i;
                    int tmp = 0;
                    while (j < data.Length && data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > maxIslandLength) { maxIslandLength = tmp; }
                }
                else
                {
                    ++i;
                }
            }
            Console.WriteLine("Leghosszabb sziget: {0}", maxIslandLength);
            Console.WriteLine("Szigetek száma: {0}", islandCount);
            Console.ReadKey();
        }
    }
}