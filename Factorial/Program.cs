using System;
using static Factorial.FactorialFunction;

namespace Factorial
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.Error.WriteLine("n is undefined");
                return 1;
            }

            if (!int.TryParse(args[0], out int n))
            {
                Console.Error.WriteLine("n is NaN");
                return 1;
            }

            try
            {
                Console.WriteLine(ComputeFactorial(n));
                return 0;
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
                return 1;
            }
        }
    }
}
