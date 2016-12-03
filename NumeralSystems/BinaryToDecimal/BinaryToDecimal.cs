using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {

        static BigInteger BinToDec(string binString)
        {
            BigInteger result = 0;

            foreach (char bit in binString)
            {
                result = result * 2 + (bit - '0');
            }

            return result;
        }

        static void Main(string[] args)
        {
            string bitString = Console.ReadLine();
            Console.WriteLine(BinToDec(bitString));
        }
    }
}
