﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Basic_Programs
{
    class Fibonacci
    {
        static void Main(String[] args)
        {
            int a = 0, b = 1, c;

            Console.WriteLine("Enter Range:");
            int range = int.Parse(Console.ReadLine());

            Console.WriteLine(a);

            for (int i = 2; i < range; i++)
            {
                c = a+b;
                Console.WriteLine(c);

                a = b;
                b = c;

            }
        }
    }
}
