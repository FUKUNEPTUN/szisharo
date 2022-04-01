using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto
    {   
        Random random = new Random();
        int talalt = 0, nyeremeny, sorsolas, b;
        int[] szam = new int[5], jatekos = new int[5];
        bool mehet = true;
        public Lotto() { }

        public void nyerek()
        {

            Console.WriteLine("A nyerőszámok:");

            for (int i = 0; i < szam.Length; i++)
            {
                sorsolas = random.Next(1, 91);
                b = 0;
                mehet = true;
                while (b < i && mehet == true)
                {
                    if (szam[b] == sorsolas)
                    {
                        mehet = false;
                        Console.WriteLine("ujra");
                    }
                    else
                    {
                        mehet = true;
                        b++;
                    }
                }
                if (mehet == true)
                {
                    szam[i] = sorsolas;
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < szam.Length; i++)
            {Console.WriteLine("--------------");
                Console.WriteLine(szam[i]);
                
            }
            Console.WriteLine("--------------");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Add meg a te számaid:");
            for (int i = 0; i < 5; i++)
            {
                jatekos[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (jatekos[i] == szam[j])
                    {
                        talalt++;
                    }
                }
            }
            switch (talalt)
            {
                case 0:
                    Console.WriteLine("Nem nyertél semmit, majd legközelebb");
                    break;
                case 1:
                    nyeremeny = random.Next(200, 500);
                    Console.WriteLine("1 darab találatod volt. Nyereményed:  {0} Forint. Gratulálok!", nyeremeny);
                    break;
                case 2:
                    nyeremeny = random.Next(501, 1000);
                    Console.WriteLine("2 darab találatod volt. Nyereményed:  {0} Forint. Gratulálok!", nyeremeny);
                    break;
                case 3:
                    nyeremeny = random.Next(1001, 3000);
                    Console.WriteLine("3 darab találatod volt. Nyereményed:  {0} Forint. Gratulálok!", nyeremeny);
                    break;
                case 4:
                    nyeremeny = random.Next(3001, 10000);
                    Console.WriteLine("4 darab találatod volt. Nyereményed:  {0} Forint. Gratulálok!", nyeremeny);
                    break;
                case 5:
                    nyeremeny = random.Next(1000001, 99999999);
                    Console.WriteLine("TELITALÁLAT!!! 5 darab találatod volt. Nyereményed:  {0} Forint. Gratulálok a főnyereményhez!", nyeremeny);
                    break;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string k = " ";
            Lotto lotto = new Lotto();
            while (k != "n")
            {
                lotto.nyerek();
                Console.WriteLine("Szeretnél egy új esélyt a főnyeremény megnyerésére? (i/n)");   
                k = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
