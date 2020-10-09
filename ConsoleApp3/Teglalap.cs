using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaszek
{
    class Teglalap : Sikidom
    {
        int a;
        int b;

        public Teglalap(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double Kerulet()
        {
            return (a + b) * 2;
        }

        public double Terulet()
        {
            return a * b;
        }
    }
}
