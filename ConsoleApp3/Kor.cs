using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaszek
{
    class Kor :Sikidom
    {
        int r;

        public Kor(int r)
        {
            this.r = r;
        }

        public double Kerulet()
        {
            return 2 * r * Math.PI;
        }

        public double Terulet()
        {
            return r * r * Math.PI;
        }
    }
}
