using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double moonGravity = 0.17;
            double weight = double.Parse(Console.ReadLine());
            double weightOnMoon = Math.Round(weight * moonGravity, 3);

            Console.WriteLine("{0:0.000}", weightOnMoon);
        }
    }
}
