namespace Printing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Printing
    {
        static void Main()
        {
            double students = double.Parse(Console.ReadLine());
            double sheetPerStudent = double.Parse(Console.ReadLine());
            double pricePerRealm = double.Parse(Console.ReadLine());
            double realmSize = 500;

            double totalSheetPerStudent = students * sheetPerStudent;
            double totalRealmCount = totalSheetPerStudent / realmSize;

            Console.WriteLine("{0:0.00}", totalRealmCount * pricePerRealm);

        }
    }
}
