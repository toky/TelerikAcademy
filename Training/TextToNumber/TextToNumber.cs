using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToNumber
{
    class TextToNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            double result = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {

                if (text[i] == '@')
                {
                    break;
                }
                if (char.IsDigit(text[i]))
                {
                    result *= text[i] - '0';
                }
                else if (char.IsLower(text[i]))
                {
                    result += text[i] - 'a';
                }
                else if (char.IsUpper(text[i]))
                {
                    result += text[i] - 'A';
                }
                else
                {
                    result %= number;
                }
            }

            Console.WriteLine("{0}", result);
        }
    }
}
