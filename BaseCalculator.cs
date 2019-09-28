using System;

namespace Calculator
{
    public class BaseCalculator
    {
        public void Multiply()
        {
            Console.WriteLine("Enter a number to multiply: ");

            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number to multiply: ");

            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} * {1} = " + (first * second), first, second);

        }
    }
}
