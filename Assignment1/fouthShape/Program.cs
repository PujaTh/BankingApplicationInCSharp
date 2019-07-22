using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FourthShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1=new Shape();
            Console.WriteLine("Enter L and B for rectangle");
                double L=Convert.ToDouble(Console.ReadLine());
                double B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of rectangle is: {0}",s1.area(L,B));
           
            Console.WriteLine("Enter the radius for circle");
                double R = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of circle is: {0}", s1.area(R));

            Console.WriteLine("Enter the side for Square");
                int S = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Area of circle is: {0}", s1.area(S));

             Console.WriteLine("Enter the 3 sides for triagle");
                double S1 = Convert.ToDouble(Console.ReadLine());
                double S2 = Convert.ToDouble(Console.ReadLine());
                double S3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of Tringle is: {0}", s1.area(S1,S2,S3));

                Console.ReadLine();
        }
    }

    class Shape
    {
        public double area(double length, double breadth)
        {
            return length * breadth;
        }

        public double area(double side1, double side2, double side3)
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;

            double product = semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3);

            return Math.Sqrt(product);
        }

        public double area(double radius)
        {
            return 3.14 * radius * radius;
        }
        public long area(int side)
        {
            return side * side;
        }
    }
}
