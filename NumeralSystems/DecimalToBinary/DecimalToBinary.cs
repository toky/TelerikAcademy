using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static string DecToBin(BigInteger number)
        {
            string result = "";

            while (number > 0)
            {
                BigInteger digit = number % 2;

                number /= 2;

                result = digit + result;
            }

            return result;
        }
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(DecToBin(number));
        }
    }
}
