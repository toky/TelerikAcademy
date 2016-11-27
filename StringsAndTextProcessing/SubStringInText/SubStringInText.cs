using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringInText
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            //string str = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            //string searchedSubStr = "in";

            string searchedSubStr = Console.ReadLine();
            string str = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < str.Length - searchedSubStr.Length + 1; i++)
            {
                string subString = str.Substring(i, searchedSubStr.Length);
                
                if (subString.Equals(searchedSubStr, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }


    }
}
