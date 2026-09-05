
namespace GeometricFigures.Backend;

public abstract class GeometricFigure
 {
    
    // property
    public string Name { get; set; } = null!;
    // constructor
    protected GeometricFigure(string name)
    {
        Name = name;
    }
    // methodsd
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString() => $"{Name,-17} => Area.....: {GetArea(),13:N5}     Perimiter: {GetPerimeter(),12:N5}";
    
}

