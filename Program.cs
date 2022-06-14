using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstCircleReact
{
    internal class Program
    {
        
            public abstract class Shape
        {
            public abstract double Area();
        }

        public class Abst_Circle_Rect : Shape
        {
            public double Radius { get; set; }
            public Abst_Circle_Rect(double radius)
            {
                Radius = radius;
            }
            public override double Area()
            {
                return (3.14) * Math.Pow(Radius, 2);
            }
        }
        public class Rectangle : Shape
        {
            public double Height { get; set; }
            public double Width { get; set; }
            public Rectangle(double height, double width)
            {
                Height = height;
                Width = width;
            }
            public override double Area()
            {
                return Height * Width;
            }
        }

        public class circle_Rect
        {
            static void Main(string[] args)
            {
                Shape circle = new Abst_Circle_Rect(2.5);
                Shape rectangle = new Rectangle(4.75, 6.25);


                Console.WriteLine("The area of the circle is " + circle.Area());
                Console.WriteLine("The area of the rectangle is " + rectangle.Area());
                Console.ReadLine();
            }
        }
    }
}
