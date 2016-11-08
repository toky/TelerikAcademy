namespace NumberOfPages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class NumberOfPages
    {
        static void Main()
        {
            int pages = int.Parse(Console.ReadLine());
            int digitCount = 0;

            for (int i = 1; i <= pages; i++)
            {
                if (i < 10)
                {
                    digitCount += 1;
                }
                else if (i < 100)
                {
                    digitCount += 2;
                }
                else if (i < 1000)
                {
                    digitCount += 3;
                }
                else if (i < 10000)
                {
                    digitCount += 4;
                }
                else if (i < 100000)
                {
                    digitCount += 5;
                }
                else if (i < 1000000)
                {
                    digitCount += 6;
                }

            }
            Console.WriteLine(digitCount);
        }
    }
}
