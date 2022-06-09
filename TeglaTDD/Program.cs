using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeglaTDD
{
    public class Harem
    {
        public Harem() { }
        public int getFelszin(int oldala, int oldalb, int oldalc)
        {
            return 2 * (oldala * oldalb + oldala * oldalc + oldalc * oldalb);
        }
        public int getTerfogat(int oldala, int oldalb, int oldalc)
        {
            return oldala * oldalb * oldalc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
