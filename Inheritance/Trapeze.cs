

namespace Backend;


public class Trapeze : Triangle
{
    private double _d;
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a,b,c,h)
    //Constructor
    {
        D = d;
    }
    //Propertier
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }
    //Methods
    public override double GetArea()
    {
        return (B + _d) * H / 2;
    }
    public override double GetPerimiter()
    {
        return A + B + C + _d;
    }
    private double ValidateD(double d)
    {
        if (d <= 0)
        {
            throw new ArgumentException($"The side D: {d}, is not valid.");
        }
            return d;
        
    }
  }
