using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Square
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
    }

    public class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public struct Rectangle
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectangle(double lenght, double height)
        {
            Length = lenght;
            Height = height;
        }
    }

    class PatternMatching
    {
        public static double ComputeArea(object shape)
        {
            if (shape is Square)
            {
                var s = (Square)shape;
                return s.Side * s.Side;
            }
            else if (shape is Rectangle r)
            {
                return r.Height * r.Length;
            }

            throw new ArgumentException
            (
                message: "shape is not a shape",
                paramName: nameof(shape)
            );
        }

        static void Main(string[] args)
        {
            Console.WriteLine( ComputeArea(1.0) );
            Console.ReadLine();
        }
    }
}
