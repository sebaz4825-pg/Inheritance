
namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{
    private double _a; 
    public Square(string name, double a) : base(name)
    {
        A = a;
    }
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }
    public override double GetArea()
    {
        return Math.Pow(_a, 2);
    }
    public override double GetPerimeter()
    {
        return 4 * _a;
    }
    private double ValidateA(double a)
    {
        if (a <=  0)
        { 
            throw new ArgumentException($"The side: {a}, is not valid.");
         }
       return a;
    }
}
