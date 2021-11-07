
using System;

namespace Rekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            //exponents
            Console.WriteLine("Hello World!");

            double Result, Number1, Number2;

            Number1 = Convert.ToInt32(Console.ReadLine());
            Number2 = 3;

            Result = Math.Pow(Number1, Number2);
            Console.WriteLine(Result);

        }
    }
}
