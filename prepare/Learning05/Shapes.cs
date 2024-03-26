public abstract class Shapes
{
    // Member Variables
    private string _color;
    private string _shapeName;

    // Getters
    public string GetColor()
    {
        return _color;
    }
        public string GetShapeName()
    {
        return _shapeName;
    }

    // Setters
    public void SetColor(string color)
    {
        _color = color;
        
    }
        public void SetShapeName(string shapeName)
    {
        _shapeName = shapeName;
        
    }

    // Constructors
    public Shapes(string color, string shapeName)
    {
        _color = color;
        _shapeName = shapeName;
    }
    // Methods
    // The reason to create a abstract method is to be able to override the the method by the context of any other class shapes.
    public abstract double GetArea();

}