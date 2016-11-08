namespace BirdsAndFeathers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MutantSquirrels
    {
        static void Main()
        {
            double numberOfTrees = double.Parse(Console.ReadLine());
            double numberOfBranches = double.Parse(Console.ReadLine());
            double numberOfsquirrelsOnBranches = double.Parse(Console.ReadLine());
            double averageNumOfSquirrelsTails = double.Parse(Console.ReadLine());

            double evenSecretNumber = 376439;
            double oddSecretNumber = 7;

            double totalSquirrelsTails = numberOfTrees * numberOfBranches * numberOfsquirrelsOnBranches * averageNumOfSquirrelsTails;

            if ((totalSquirrelsTails % 2) == 0)
            {
                totalSquirrelsTails *= evenSecretNumber;
            }
            else
            {
                totalSquirrelsTails /= oddSecretNumber;
            }

            Console.WriteLine("{0:0.000}", totalSquirrelsTails);
        }
    }
}
