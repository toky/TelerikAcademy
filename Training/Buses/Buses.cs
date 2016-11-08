namespace Buses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Buses
    {
        static void Main()
        {
            int bussesCount = int.Parse(Console.ReadLine());
            int bussesGroupCount = 0;
            int prevBussSpeed = int.MaxValue;
            int bussesGroupSpeed = int.MinValue;

            for (int i = 0; i < bussesCount; i++)
            {
                int currentBussSpeed = int.Parse(Console.ReadLine());

                bool isNewGroup = (prevBussSpeed > currentBussSpeed) || (prevBussSpeed == currentBussSpeed);

                if (isNewGroup)//create new group
                {
                    bussesGroupCount += 1;
                    bussesGroupSpeed = currentBussSpeed;
                    prevBussSpeed = currentBussSpeed;
                }




            }

            Console.WriteLine(bussesGroupCount);
        }
    }
}
