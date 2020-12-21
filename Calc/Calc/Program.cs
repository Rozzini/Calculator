using System;

namespace Calc
{
    class Program
    {

        class Calc
        {
            public int plus(int x, int y)
            {
                return x + y;
            }
            public int minus(int x, int y)
            {
                return x - y;
            }
        }
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            Console.WriteLine(calc.plus(5, 2));
        }
    }
}
