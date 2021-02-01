using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return (a + b);
        }

        public double Subtract(double a, double b)
        {
            return (a - b);
        }

        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        public double Power(double a, double exp)
        {
            return Math.Pow(a, exp);
        }

        public static void Main(String[] args)
        {

            Console.WriteLine("Main Method");
        }
    }
}
