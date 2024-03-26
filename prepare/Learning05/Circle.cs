public class Circle : Shapes
{
    // Member variables
    private double _radius;
    
    // Constructors
    public Circle(string color, string shapeName, double radius) : base (color, shapeName)
    {
        _radius = radius;
    }

    // Methods
    // I used override method type to be able to change the behaviour of the GetArea() method.
    public override double GetArea()
    {
        return (_radius * _radius) * 3.1416;
    }


}