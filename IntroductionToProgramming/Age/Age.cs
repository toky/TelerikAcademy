using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime birthDay = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);
            DateTime now = DateTime.Now;
            int age = ((now - birthDay).Days / 365);
            Console.WriteLine(age);
            Console.WriteLine(age + 10);

        }
    }
}
