using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaszek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidom = new List<Sikidom>();
            sikidom.Add(new Negyzet(3));
            sikidom.Add(new Teglalap(3, 4));
            sikidom.Add(new Kor(4));
            sikidom.Add(new Negyzet(5));

            double sum = 0;
            foreach (Sikidom item in sikidom)
            {
                sum += item.Terulet();
            }

            Console.WriteLine("Területük: {0}", sum);
            Console.WriteLine("Program vége");
            Console.ReadKey();
        }
    }
}
