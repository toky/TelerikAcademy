using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int openBracketCount = CountBrackets(inputString, '(');
            int closeBracketCount = CountBrackets(inputString, ')');

            if (openBracketCount == closeBracketCount)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

        }

        static int CountBrackets(string str, char bracket)
        {
            int countBrackets = 0;
            int index = 0;

            while ((index = str.IndexOf(bracket, index)) >= 0)
            {


                if (index >= 0)
                {
                    countBrackets++;
                }
                index++;

            }

            return countBrackets;
        }
    }
}
