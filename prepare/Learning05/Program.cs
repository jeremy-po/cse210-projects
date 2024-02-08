using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 6);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 8, 10);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 12);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string colour = s.GetColour();
            double area = s.GetArea();
            Console.WriteLine($"The {colour} shape has an area of {area}.");
        }
    }
}
