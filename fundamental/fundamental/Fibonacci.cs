using System;

namespace fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Range :");
            int range = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c;

            Console.Write(a+" "+ b+ " ");
           

            for (int count = 2; count <range; count++)
            {
                c = a + b;
                Console.Write(c+" ");
                //Console.ReadLine();
               
                a = b;
                b = c; 
            }
            Console.Read();
        }
    }
}
