namespace Speeds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Speeds
    {
        static void Main()
        {

            int carNumbers = int.Parse(Console.ReadLine());

            int currentGroupSpeed = int.MaxValue;
            int currentGroupSumSpeed = 0;
            int currentGroupCount = 0;
            int maxGroupCount = 0;
            int maxGroupSpeed = 0;

            for (int i = 0; i < carNumbers; i++)
            {
                int currentCarSpeed = int.Parse(Console.ReadLine());

                if (currentGroupSpeed >= currentCarSpeed) // is new group
                {
                    if (currentGroupCount > maxGroupCount)
                    {
                        maxGroupCount = currentGroupCount;
                        maxGroupSpeed = currentGroupSumSpeed;
                    }
                    else if (currentGroupCount == maxGroupCount && currentGroupCount > 0)
                    {
                        if (currentGroupSumSpeed > maxGroupSpeed)
                        {
                            maxGroupSpeed = currentGroupSumSpeed;
                        }
                    }

                    currentGroupSpeed = currentCarSpeed;
                    currentGroupSumSpeed = currentCarSpeed;
                    currentGroupCount = 1;
                }
                else
                {
                    currentGroupSumSpeed += currentCarSpeed;
                    currentGroupCount++;
                }

            }


            if (currentGroupCount > maxGroupCount)
            {
                maxGroupCount = currentGroupCount;
                maxGroupSpeed = currentGroupSumSpeed;
            }
            else if (currentGroupCount == maxGroupCount && currentGroupCount > 0)
            {
                if (currentGroupSumSpeed > maxGroupSpeed)
                {
                    maxGroupSpeed = currentGroupSumSpeed;
                }
            }

            Console.WriteLine(maxGroupSpeed);



        }
    }
}
