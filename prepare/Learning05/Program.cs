using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes = new List<Shapes>();
        Square square = new Square("Blue", "Square", 5 );
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Yellow", "Rectangle", 10, 15 );
        shapes.Add(rectangle);

        Circle circle = new Circle("Red", "Circle", 3);
        shapes.Add(circle);


        foreach(Shapes s in shapes)
        {
            string color = s.GetColor();
            string shapeName = s.GetShapeName();
            double area = s.GetArea();

            Console.WriteLine($"The {shapeName} is {color} and it's area is {area}.\n");
        }
    }
}