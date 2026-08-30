

namespace Backend;

public class Triangle : Rectangle

{
    //Fields
    private double _c;
    private double _h;


    //Constructor
    public Triangle(string name, double a, double b, double c, double h) : base(name, a,b)
    {
        C = c;
        H = h;
    }
    // Propertier
    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }
    // Methods
    public override double GetArea()
    {
        return (B * H) / 2;
    }
    public override double GetPerimiter()
    {
        return A + B + _c;
    }
    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new ArgumentException($"The sice C: {c}, is not valid.");
        }
        return c;
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
