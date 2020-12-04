using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfACircle
{
    public class Circle
    {
        public static double AreaCircle(double radius)
        {
            double area;
            double PI = Math.PI;
            area = radius * radius * PI;
            return area;
        }

        public static double Circumference(double radius)
        {
            double circumference;
            double PI = Math.PI;
            circumference = 2 * PI * radius;
            return circumference;
        }

        public static double Diameter(double radius)
        {
            double diameter;
            double PI = Math.PI;
            diameter = 2 * radius;
            return diameter;
        }
    }

}
