using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Oszthat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ehes eh = new Ehes();
            eh.setSzam();
            eh.getSzam();
            Console.ReadKey();


        }
    }
}
