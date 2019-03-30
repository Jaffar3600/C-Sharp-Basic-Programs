using System;

namespace C_Sharp_Basic_Programs
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------WELCOME TO CALCULATOR--------------------");

            Console.WriteLine("Enter any one operator to perform operation +, -, *, /");
            String oper = Console.ReadLine();

            Console.WriteLine("Enter first operand:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second operand:");
            int num2 = int.Parse(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    Console.WriteLine("Your Answer is:"+ (num1+num2));
                    Console.ReadLine();
                    break;

                case "-":
                    Console.WriteLine("Your Answer is:" + (num1 - num2));
                    Console.WriteLine("Thank you visit again");
                    Console.ReadLine(); 
                    break;

                case "*":
                    Console.WriteLine("Your Answer is:" + (num1 * num2));
                    Console.WriteLine("Thank you visit again");
                    Console.ReadLine();
                    break;

                case "/":
                    Console.WriteLine("Your Answer is:" + (num1 / num2));
                    Console.WriteLine("Thank you visit again");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
