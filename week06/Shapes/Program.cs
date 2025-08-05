using System;
using System.ComponentModel;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 4);
        Rectangle rectangle = new Rectangle("blue", 3, 5);
        Circle circle = new Circle("green", 5);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape} is {shape.GetColor()} with an area of {shape.GetArea()}");
        }

    }
}