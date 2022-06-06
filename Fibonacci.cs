using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    internal class Fibonacci
    {

        public void run()
        {

            Console.WriteLine("Enter the Number:");
            int fib = Convert.ToInt32(Console.ReadLine());


            int n1 = -1, n2 = 1, n3 = 0;

            for (int i = 0; i < fib; i++)
            {

                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;

            }
            




        }
        

    }
}
