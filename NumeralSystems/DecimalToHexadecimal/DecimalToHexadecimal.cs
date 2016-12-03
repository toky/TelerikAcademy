using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static string DecToHex(BigInteger number)
        {
            string result = "";
            string hex = "0123456789ABCDEF";
            while (number > 0)
            {
                int hexIndex = (int)(number % 16);
                result = hex[hexIndex] + result;
                number /= 16;

            }

            return result;
        }
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(DecToHex(number));
        }
    }
}
