namespace BirdsAndFeathers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            double birds = int.Parse(Console.ReadLine());
            double feathers = int.Parse(Console.ReadLine());
            bool isEven = true;
            double averageFeathersPerBirds = feathers / birds;
            double result;
            isEven = (birds % 2) == 0;

            if (birds > 0)
            {
                if (isEven)
                {
                    result = averageFeathersPerBirds * 123123123123;
                }
                else
                {
                    result = averageFeathersPerBirds / 317;
                }
            }
            else
            {
                result = 0;
            }
            Console.WriteLine("{0:0.0000}", result);
        }
    }
}
