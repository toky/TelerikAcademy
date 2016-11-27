using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReverseStr(input));
        }

        static string ReverseStr(string str)
        {
            StringBuilder reversedString = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString.Append(str[i]);
            }

            return reversedString.ToString();
        }
    }
}
