﻿using System;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int numb = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (numb > 0)
            {
                int rem = numb % 10;
                reverse = (reverse * 10) + rem;
                numb = numb / 10;

            }
            Console.WriteLine("Reverse number={0}", reverse);
            Console.ReadLine();
        }
    }
}
