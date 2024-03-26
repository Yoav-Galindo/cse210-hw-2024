public class Rectangle : Shapes
{
    // Member variables
    public double _length;
    public double _width;

    // Constructors
    public Rectangle(string color, string shapeName, double length, double width) : base (color, shapeName)
    {
        _length = length;
        _width = width;
    }
    // Methods
    // I used override method type to be able to change the behaviour of the GetArea() method.
    public override double GetArea()
    {
        return _length * _width;
    }


}