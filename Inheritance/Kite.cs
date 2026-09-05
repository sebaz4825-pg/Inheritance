
namespace GeometricFigures.Backend;

public class Kite : Rhombus
    {
    //Fields
        private double _b;
        //Constructor
        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
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
            return base.GetArea();
        }
        public override double GetPerimeter()
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
