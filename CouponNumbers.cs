using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    internal class CouponNumbers
    {

        public void run()
        {

            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());



            Random r = new Random();
            int[] arr = new int[num];
            int i, j, k;

            for (i = 0; i < num; i++)
            {
                int check = r.Next(1, (num + 1));
                for (j = 0; j <= i - 1; j++)
                {
                    if (arr[j] == check)
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    arr[i] = check;
                }
                else
                {
                    i--;
                }

            }
            for (k = 0; k < num; k++)
            {
                Console.WriteLine(arr[k]);
            }


        }

    }
}
