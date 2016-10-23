using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numberLenght = number.Length;
            int thirdDigirIndex = numberLenght - 3;
            char thirdDigir = number[thirdDigirIndex];

            if (numberLenght >= 3)
            {


                if (thirdDigir == '7')
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false {0}", thirdDigir);
                }
            }
            else
            {
                Console.WriteLine("false {0}", thirdDigir);
            }
        }
    }
}
