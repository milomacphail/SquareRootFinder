using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCalculator testMultiply = new BaseCalculator();
            testMultiply.Multiply();

            ScientificCalculator testSquareRoot = new ScientificCalculator();
            testSquareRoot.SquareRoot();
        }
    }
}
