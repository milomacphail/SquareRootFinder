using System;

namespace Calculator
{
    public class ScientificCalculator
    {
        public void SquareRoot()
        {

        double input = 0.0;

        double decimalPrecision = 0.0;

        Console.WriteLine("Enter number to square root: ");
                input = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter decimal place to which to round square root (use decimal): ");
                decimalPrecision = Convert.ToDouble(Console.ReadLine());

                if(input< 0)
                {
                    Console.WriteLine("Input must be larger than 0");
                    return;
                }

                if (input == 0)
                {
                    Console.WriteLine("The square root of 0 is 0. Please stop wasting my time and yours.");
                    return;
                }

                double inputByTen = input / 10;
                double inputByInputByTen = input / inputByTen;

                do
                {
                    Console.WriteLine("Square root of " + input +" = " + inputByTen);
                    inputByTen = (inputByTen + inputByInputByTen) / 2;
                    inputByInputByTen = input / inputByTen;
                } while (inputByTen - inputByInputByTen > decimalPrecision);

                Console.ReadKey();
        }
    
     }
}
