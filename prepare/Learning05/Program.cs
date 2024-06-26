using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("yellow", 3);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectange rectangle = new Rectange("orange", 4,6);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("blue", 6);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}