using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{

    public interface ICalculator
    {
        void CalculateAreaOfCircle(double radius);
        void Add();
        void Subtract();

    }

    public class CalculatorPrecise : ICalculator
    {

        
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void CalculateAreaOfCircle(double radius)
        {
            double pi = System.Math.PI;
            decimal areaOfCircle = (decimal)(radius * radius * pi);
            Console.WriteLine($"The area of the circle is: {areaOfCircle}");
        }

        public void Subtract()
        {
            throw new NotImplementedException();
        }
    }

    public class CalculatorStandard : ICalculator
    {
        public const double PI = 3.14159;

        public CalculatorStandard(){}

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Subtract()
        {
            throw new NotImplementedException();
        }

        internal void CalculateAreaOfCircle(double radius)
        {
            double areaOfCircle = radius * radius * CalculatorStandard.PI;
            Console.WriteLine($"The area of the circle is: {areaOfCircle}");
        }

        void ICalculator.CalculateAreaOfCircle(double radius)
        {
            throw new NotImplementedException();
        }
    }
}
