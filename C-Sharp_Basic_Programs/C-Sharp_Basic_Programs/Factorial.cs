using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Basic_Programs
{
    class Factorial
    {
        static void Main(String[] args)
        {
            int fact = 1;

            Console.WriteLine("Enter Number to find Factorial:");
            int num =int.Parse(Console.ReadLine());

            for(int count = 1; count <= num; count++)
            {
                fact = fact * count;
            }
            Console.WriteLine("Factorial of given number is:"+fact);
            Console.ReadLine();
        }
    }
}
