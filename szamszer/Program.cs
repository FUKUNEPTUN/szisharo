using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamszer
{
    class Program
    {
        static void Main(string[] args)
        {
            int alsohatar = 1,
                felsohatar = 11,
                probal = 5,
                gondoltszam,
                tipp;
                
            Random rnd = new Random();
            do
            {
                Console.WriteLine("Leszel az aki gondol egy szamra?");
                if (Console.ReadLine() == "n")
                {
                    gondoltszam = rnd.Next(alsohatar, felsohatar);
                    for (int i = 0; i <= probal; i++)
                    {
                        Console.WriteLine("tippeljen");
                        tipp = int.Parse(Console.ReadLine());
                        if (gondoltszam < tipp)
                        {
                            Console.WriteLine("kisebbre gondoltam ciganyy");
                            
                        }
                        else if(gondoltszam > tipp){
                            Console.WriteLine("Nagyobbat tippeljen kakálj be");
                        }
                        else
                        {
                            Console.WriteLine("gratulalok világi cigany vagy");
                            break;
                        }
                    }
                }

                Console.WriteLine("Folytatjuk? (i/n)");
            } while(Console.ReadLine() == "i");
            Console.ReadKey();

        }
    }
}
