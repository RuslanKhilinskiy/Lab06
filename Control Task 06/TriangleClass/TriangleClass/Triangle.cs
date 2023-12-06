using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClass
{
    class Triangle
    {
        private double sideA, sideB, sideC;
        public bool InitializingSides(double a, double b, double c)
        {
            if (TriangeCheck(a,b,c))
            {
                sideA = a;
                sideB = b;
                sideC = c;
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect values of the triangle's sides");
                return false;
            }
        }
        public void InputSidesValues()
        {
            Console.WriteLine("Enter the value of the first side: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of the second side: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of the third side: ");
            double c = Convert.ToDouble(Console.ReadLine());

            InitializingSides(a, b, c);
        }
        public double PerimeterCount()
        {
            return sideA + sideB + sideC;
        }
        public double SquareCount()
        {
            double square = PerimeterCount() / 2;
            return Math.Sqrt(square * (square - sideA) * (square - sideB) * (square - sideC));
        }
        public void OutputSidesValues()
        {
            Console.WriteLine($"The first tiangle's side: {sideA}");
            Console.WriteLine($"The second tiangle's side: {sideB}");
            Console.WriteLine($"The third tiangle's side: {sideC}");
        }
        private bool TriangeCheck(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle();
            myTriangle.InputSidesValues();
            myTriangle.OutputSidesValues();
            Console.WriteLine($"Perimeter: {myTriangle.PerimeterCount()}");
            Console.WriteLine($"Square: {myTriangle.SquareCount()}");
        }
    }
}
