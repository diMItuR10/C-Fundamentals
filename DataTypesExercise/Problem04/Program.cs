﻿using System;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
