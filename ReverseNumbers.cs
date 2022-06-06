using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    internal class ReverseNumbers
    {

        public void run()
        {


            Console.Write("Enter the Count: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Numbers: ");
            int[] num = new int[count];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nEntered Numbwes: ");
            foreach (int a in num)
            {
                Console.Write(" " + a);
            }

            Array.Reverse(num);
            Console.WriteLine("\n \nReversed Numbers:");
            foreach (int b in num)
            {
                Console.Write(" " + b);
            }

        }

    }
}
