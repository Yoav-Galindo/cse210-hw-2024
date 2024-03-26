public class Square : Shapes
{   
    // Member Variables
    private double _side;

    // Constructors
    public Square(string color, string shapeName, double side) : base (color, shapeName)
    {
        _side = side;
    }

    // Methods
    // I used override method type to be able to change the behaviour of the GetArea() method.
    public override double GetArea()
    {
        return _side * _side;
    }

}