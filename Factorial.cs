﻿using System;



namespace LibraryParadigms
{
    // this program computes the factorial of numbersgkjgkjhjkhgkjh
    class Program
    {
        public static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        static void Main(string[] args)
            // this is main
        {
            Console.WriteLine("Dose enan thetiko akeraio");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(x));
        }

    }
}


