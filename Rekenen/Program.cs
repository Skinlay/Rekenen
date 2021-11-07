
using System;

namespace Rekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //exponents
            Console.WriteLine("Hello World!");

            double Result, Number1, Number2;

            Number1 = Convert.ToInt32(Console.ReadLine());

            Result = Math.Pow(Number1, 3);
            Console.WriteLine(Result);
            */

            /*
            //Oppervlakte driehoek = (BASIS x HOOGTE)/2

            double oppervlakte, Number1, Number2;

            Console.WriteLine("de lengte van de onderkant van de driehoek");
            Number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("de lengte van de hoogt van de driehoek");
            Number2 = Convert.ToInt32(Console.ReadLine());

            oppervlakte = (Number1 * Number2) / 2;
            Console.WriteLine("de oppervlakte van de driehoek is: " + oppervlakte);
            */

            double ResultA, ResultB, ResultC, ResultD, zijdeA, zijdeB;

            zijdeA = Convert.ToInt32(Console.ReadLine());
            zijdeB = Convert.ToInt32(Console.ReadLine());

            ResultA = Math.Pow(zijdeA, 2);
            ResultB = Math.Pow(zijdeB, 2);
            ResultC = ResultA + ResultB;
            ResultD = Math.Sqrt(ResultC);

            Console.WriteLine(ResultD);


        }
    }
}
