using AbstractClasses.Enums;
using NamespaceName;

namespace AbstractClasses.Model;

public abstract class FormaGeometrica : IFormaGeometrica
{
   public Cor Cor { get; set; }
   public string? Description { get; set; }

    public abstract double Area();
    public abstract double Perimetro();
}

