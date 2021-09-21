using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAreaOfACircleOrTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //S = πR² Math.Pow(radius, 2)
            //Console.WriteLine("enter the radius of the circle or the three sides of the triangle");
            double square;
            Console.Write("what to find, the radius of a circle or the area of a triangle?(1 or 2)");
            int a = Int32.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Enter the radius.(in cm)");
                double radius = Int32.Parse(Console.ReadLine());
                square = Math.Pow(radius, 2) * 3.14;
                Console.WriteLine($"{square}");
            }
            else
            {
                Console.WriteLine("Enter the 3 sides of the triangle.(in cm)");
                double side1 = Int32.Parse(Console.ReadLine());
                double side2 = Int32.Parse(Console.ReadLine());
                double side3 = Int32.Parse(Console.ReadLine());
                double p = (side1 + side2 + side3)/2;
                square = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                Console.WriteLine($"{square}");
            }
            Console.ReadLine();
        }
    }
}
