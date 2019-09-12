using System;
using Microsoft.Win32.SafeHandles;


namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {


            // Integer Mathematics

            //int a = 18;
            //int b = 5;
            //int c = a + b;
            //int d = a - b;
            //int e = a * b;
            //int f = a / b;
            //int g = a % b;

            //Console.WriteLine($"Addition of {a} + {b} = {c}");
            //Console.WriteLine($"Subraction of {a} - {b} = {d}");
            //Console.WriteLine($"Multiplication of {a} * {b} = {e}");
            //Console.WriteLine($"Division of {a} / {b} = {f}");
            //Console.WriteLine($"Modulus of {a} % {b} = {g}");

            //double a = 1;
            //double b = 3;
            //double c = a + b;
            //double d = a - b;
            //double e = a * b;
            //double f = a / b;
            //double g = a % b;

            //Console.WriteLine($"Addition of {a} + {b} = {c}");
            //Console.WriteLine($"Subraction of {a} - {b} = {d}");
            //Console.WriteLine($"Multiplication of {a} * {b} = {e}");
            //Console.WriteLine($"Division of {a} / {b} = {f}");
            //Console.WriteLine($"Modulus of {a} % {b} = {g}");


            //decimal a = 1;
            //decimal b = 3;
            //decimal c = a + b;
            //decimal d = a - b;
            //decimal e = a * b;
            //decimal f = a / b;
            //decimal g = a % b;

            //Console.WriteLine($"Addition of {a} + {b} = {c}");
            //Console.WriteLine($"Subraction of {a} - {b} = {d}");
            //Console.WriteLine($"Multiplication of {a} * {b} = {e}");
            //Console.WriteLine($"Division of {a} / {b} = {f}");
            //Console.WriteLine($"Modulus of {a} % {b} = {g}");


            //int iMax = int.MaxValue;
            //int iMin = int.MinValue;
            //Console.WriteLine($"The range of integers is from {iMin} to {iMax}");

            //double dMax = double.MaxValue;
            //double dMin = double.MinValue;
            //Console.WriteLine($"The range of doubles is from {dMin} to {dMax}");

            //decimal decMax = decimal.MaxValue;
            //decimal decMin = decimal.MinValue;
            //Console.WriteLine($"The range of decimals is from {decMin} to {decMax}");


            double radius = 2.5;
            double area = radius * radius * Math.PI;
            Console.WriteLine($"The area of a circle with radius 2.5 is {area}");


            // camelCase - variables, fields, etc.
            // PascelCase - Classes, Methods, Namespaces, Properties



            //DisplayIntMath();
            //DisplayDoubleMath();
            //DisplayDecimalMath();
            //DisplayMaxMinIntValues();
            //DisplayMaxMinDoubleValues();
            //DisplayMaxMinDecimalValues();

            //double radius = 5;
            //ICalculator calculator;

            //calculator = new CalculatorStandard();
            //calculator.CalculateAreaOfCircle(radius);

            //calculator = new CalculatorPrecise();
            //calculator.CalculateAreaOfCircle(radius);

        }

        private static void DisplayIntMath()
        {
            int a = 18;
            int b = 5;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;

            Console.WriteLine($"addition: {c}");
            Console.WriteLine($"subtraction: {d}");
            Console.WriteLine($"multiplication: {e}");
            Console.WriteLine($"division: {f}");
            Console.WriteLine($"modulus: {g}");
        }

        private static void DisplayDoubleMath()
        {
            double a = 1.0;
            double b = 3.0;
            double c = a + b;
            double d = a - b;
            double e = a * b;
            double f = a / b;
            double g = a % b;

            Console.WriteLine($"addition: {c}");
            Console.WriteLine($"subtraction: {d}");
            Console.WriteLine($"multiplication: {e}");
            Console.WriteLine($"division: {f}");
            Console.WriteLine($"modulus: {g}");
        }

        private static void DisplayDecimalMath()
        {
            decimal a = 1.0M;
            decimal b = 3.0M;
            decimal c = a + b;
            decimal d = a - b;
            decimal e = a * b;
            decimal f = a / b;
            decimal g = a % b;

            Console.WriteLine($"addition: {c}");
            Console.WriteLine($"subtraction: {d}");
            Console.WriteLine($"multiplication: {e}");
            Console.WriteLine($"division: {f}");
            Console.WriteLine($"modulus: {g}");
        }

        private static void DisplayMaxMinIntValues()
        {
            int iMax = int.MaxValue;
            int iMin = int.MinValue;
            Console.WriteLine($"iMax Value: {iMax}");
            Console.WriteLine($"iMin Value: {iMin}");
        }

        private static void DisplayMaxMinDoubleValues()
        {
            double dMax = double.MaxValue;
            double dMin = double.MinValue;
            Console.WriteLine($"dMax Value: {dMax}");
            Console.WriteLine($"dMin Value: {dMin}");
        }

        private static void DisplayMaxMinDecimalValues()
        {
            decimal decMax = decimal.MaxValue;
            decimal decMin = decimal.MinValue;
            Console.WriteLine($"decMax Value: {decMax}");
            Console.WriteLine($"decMin Value: {decMin}");
        }
    }
}
