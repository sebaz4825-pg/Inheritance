

namespace Backend;

public class Parallelogram : Rectangle

{
    private double _h;

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    
    //Constructor
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
    public override double GetPerimiter()
    {
        return base.GetPerimiter();
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