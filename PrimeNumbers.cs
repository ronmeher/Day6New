using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    internal class PrimeNumbers
    {

        public void run()
        {

            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int i, j;
            for (i = 1; i <= num; i++)
            {
                for (j = 2; j < num; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    Console.WriteLine(i);
                }

            }


        }
    }
}
