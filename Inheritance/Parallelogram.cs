

namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle

{
    private double _h;
    //Constructor
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b) 
    {
        H = h;
    }
    //Propertier
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }
    //Methods
    public override double GetArea()
    {
        return B * _h;
    }
    public override double GetPerimeter()
    {
        return base.GetPerimeter();
    }
    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException($"The height: {h}, is not valid.");
        }
        return h;
    }
}