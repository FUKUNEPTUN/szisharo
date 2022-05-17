using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger3
{
    public class Hengerke
    {
        double sugar, magassag;
        public Hengerke() {
        }
        public void setSugar()
        {
            sugar =Convert.ToDouble(Console.ReadLine());
        }
        public void setSugar(double a)
        {
            sugar = a;
        }
        public void setMagassag()
        {
            magassag = Convert.ToDouble(Console.ReadLine());
        }
        public void setMagassag(double a)
        {
            magassag = a;
        }
        public double getTerulet()
        {
            return Math.Round(Math.Pow(sugar,2)*Math.PI, 2);
        }
        public double getKerulet()
        {
            return Math.Round(sugar*2 * Math.PI,2);
        }
        public double getFelszin()
        {
            return Math.Round(getTerulet()*2 + getKerulet()*magassag,2) ;
        }
        public double getTerfogat()
        {
            return Math.Round( getTerulet()* magassag,2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
