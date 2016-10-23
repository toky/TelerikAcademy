using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double width, height, area, perimeter;

            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());

            area = width * height;
            perimeter = 2 * (width + height);

            Console.Write("{0:0.00} {1:0.00}", area, perimeter);
        }
    }
}
