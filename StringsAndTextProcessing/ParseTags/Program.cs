using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string input = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            bool isUpper = false;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i].Equals('<') && input.Substring(i, 8).Equals("<upcase>"))
                {
                    isUpper = true;
                    //input = input.Remove(i, 8);
                }
                if (input[i].Equals('<') && input.Substring(i, 9).Equals("</upcase>"))
                {
                    isUpper = false;
                    //input = input.Remove(i, 9);

                }

                if (isUpper)
                {
                    builder.Append(Char.ToUpper(input[i]));
                }

                else
                {
                    builder.Append(input[i]);
                }

            }
            builder.Replace("<UPCASE>", "");
            builder.Replace("</upcase>", "");
            Console.WriteLine(builder);


        }
    }
}
