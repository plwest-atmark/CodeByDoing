using System;

namespace InputAndOutput
{
    class Program
    {

        static void Main(string[] args)
        {
            // This is a comment, it is not code. It's my notes.
            // This asks for your name, 
            // then stores it in 'name' and then says "Hello {name}"


            //Console.Write("What is your name?: ");
            //string name = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine($"Hello {name}");


            // We will create 2 integer variables, and do simple math with them.

            DisplayIntegerMath();
            DisplayDoubleMath();
            DisplayDecimalMath();

            CalculateTheAreaOfACircle(2.5);



        }

        private static void CalculateTheAreaOfACircle(double v)
        {

            // do this

        }

        private static void DisplayIntegerMath()
        {
            int a = 18;
            int b = 5;
            int c = a + b; // addition
            int d = a - b; // subtraction
            int e = a * b; // multiplication
            int f = a / b; // division
            int g = a % b; // modulus

            Console.WriteLine();
            Console.WriteLine("------------ Integer ------------");
            Console.WriteLine($"The addition of {a} + {b} = {c}");
            Console.WriteLine($"The subraction of {a} - {b} = {d}");
            Console.WriteLine($"The multiplication of {a} * {b} = {e}");
            Console.WriteLine($"The division of {a} / {b} = {f}");
            Console.WriteLine($"The modulus of {a} % {b} = {g}");
        }

        private static void DisplayDoubleMath()
        {
            double a = 18;
            double b = 6;
            double c = a + b; // addition
            double d = a - b; // subtraction
            double e = a * b; // multiplication
            double f = a / b; // division

            Console.WriteLine();
            Console.WriteLine("------------ Double ------------");
            Console.WriteLine($"The addition of {a} + {b} = {c}");
            Console.WriteLine($"The subraction of {a} - {b} = {d}");
            Console.WriteLine($"The multiplication of {a} * {b} = {e}");
            Console.WriteLine($"The division of {a} / {b} = {f}");
        }

        private static void DisplayDecimalMath()
        {
            decimal a = 18;
            decimal b = 6;
            decimal c = a + b; // addition
            decimal d = a - b; // subtraction
            decimal e = a * b; // multiplication
            decimal f = a / b; // division

            Console.WriteLine();
            Console.WriteLine("------------ Decimal ------------");
            Console.WriteLine($"The addition of {a} + {b} = {c}");
            Console.WriteLine($"The subraction of {a} - {b} = {d}");
            Console.WriteLine($"The multiplication of {a} * {b} = {e}");
            Console.WriteLine($"The division of {a} / {b} = {f}");
        }
    }
}
