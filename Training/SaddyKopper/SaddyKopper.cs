namespace SaddyKopper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    class SaddyKopper
    {
        static void Main()
        {
            string number = "123456789";

            int numberSize = number.Length;
            BigInteger result = 1;
            int sumOfNumbers = 0;
            int transformationCount = 0;

            while (result.ToString().Length > 0)
            {
                numberSize = number.Length;
                while (numberSize > 0)
                {
                    --numberSize;

                    for (int i = 0; i < numberSize; i++)
                    {
                        if ((i % 2) == 0)
                        {
                            sumOfNumbers += (int)number[i] - '0';
                        }

                    }

                    if (sumOfNumbers > 0)
                    {
                        result *= sumOfNumbers;
                    }
                    else
                    {
                        result *= 1;
                    }

                    sumOfNumbers = 0;
                }
                transformationCount++;

                
            }

            



            Console.WriteLine(transformationCount);
            Console.WriteLine(number);
        }
    }
}
