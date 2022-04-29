using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyzet
{
        public class Negyszog
        {
            // Tagváltozó
            public double Side { get; set; }

            // Konstruktor
            public Negyszog(double side)
            {
                this.Side = side;
            }

            // Kerület
            public double Kerulet()
            {
                return 4 * this.Side;
            }

            // Terület
            public double Terulet()
            {
                return Math.Pow(this.Side, 2);
            }

            // Átló
            public double Atlo()
            {
                return Math.Sqrt(2 * Math.Pow(this.Side, 2));
            }
        }

    }

