

namespace Backend;

    public class Circle : GeometricFigure
    {
        private double _r;
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }
        public double R
        {
            get => _r;
            set => _r = ValidateR(value); 

        }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_r, 2);
    }
    public override double GetPerimiter()
    {
        return 2 * Math.PI * _r; 
    }
    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException($"The radius: {r}, is not valid."); 
        }
        return r;
    }

    }

