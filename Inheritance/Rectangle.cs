
namespace Backend;

public class Rectangle : Square
{
  private double _b;
  public Rectangle(string name, double a, double b) : base(name, a)
    //Constructor
  { 
    B = b;
  }
//Propertier
  public double B
  {
    get => _b;
    set => _b = ValidateB(value);
  }
//Methods
  public override double GetArea()
  {
    return A * _b;
  }
  public override double GetPerimiter()
  {
    return 2 * (A + _b);
  }
  private double ValidateB(double b)
  {
    if (b <= 0)
    {
        throw new ArgumentException($"The side B: {b}, is not valid.");
    }
    return b;
    }
}
    