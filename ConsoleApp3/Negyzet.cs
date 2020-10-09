using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaszek
{
    class Negyzet : Sikidom
    {
        int a;

        public Negyzet(int a)
        {
            this.a = a;
        }

        public double Kerulet()
        {
            return 4 * a;
        }

        public double Terulet()
        {
            return a * a;
        }
    }
}
