using System;

namespace Calculations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
        }
    }
}
