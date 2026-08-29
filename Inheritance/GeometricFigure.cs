
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

    public override string ToString() => $"{Name}\n" + $" => Area.....: {GetArea(),12:N5}\n" + $"Perimiter: {GetPerimiter(),12:N5}\n";
    
}

