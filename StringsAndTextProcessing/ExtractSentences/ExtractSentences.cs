using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            //string word = "in";
            string word = " " + Console.ReadLine() + " ";
            //string inputText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string inputText = Console.ReadLine();
            string[] splitedStrings = inputText.Split('.');

            foreach (var str in splitedStrings)
            {

                int count = 0;
                for (int i = 0; i < str.Length - word.Length + 1; i++)
                {
                    string subString = str.Substring(i, word.Length);

                    if (subString.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;

                    }
                }
                if (count > 0)
                {
                    Console.Write(str + ".");
                }

            }

        }
    }
}
