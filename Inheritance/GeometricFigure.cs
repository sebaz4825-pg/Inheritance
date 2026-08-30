
namespace Backend;

public abstract class GeometricFigure
 {
    
    // property
    public string Name { get; set; } = null!;
    // constructor
    protected GeometricFigure(string name)
    {
        Name = name;
    }
    // methods
    public abstract double GetArea();
    public abstract double GetPerimiter();

    public override string ToString() => $"{Name}\n" + $" => Area.....: {GetArea():N5}\n" + $"Perimiter: {GetPerimiter():N5}\n";
    
}

