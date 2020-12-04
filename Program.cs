using System;
using System.Security.Cryptography.X509Certificates;

namespace AreaOfACircle
{
    class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double area;
            string input;
            double circumference;

            Console.WriteLine("What is the radius? ");
            input = Console.ReadLine();
            radius = double.Parse(input);
            area = Circle.AreaCircle(radius);
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);
            circumference = Circle.Circumference(radius);
            Console.WriteLine("The circumference of a circle with radius " + radius + " is: " + circumference);
            double diameter = Circle.Diameter(radius);
            Console.WriteLine("The diameter of the circle with the radius " + radius + " is: " + diameter);

            // Console.WriteLine(Circle.AreaCircle(radius));

            Console.WriteLine("What is your car's MPG?: ");
            input = Console.ReadLine();
            int mpg = int.Parse(input);  // 
            double gallonsGasUsed = diameter / mpg;
            Console.WriteLine("The car will use " + gallonsGasUsed + " gallons of gas going around the circle.");
        }
    }
}