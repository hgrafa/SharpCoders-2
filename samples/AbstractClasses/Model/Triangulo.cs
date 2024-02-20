using NamespaceName;

namespace AbstractClasses.Model;

public class Triangulo : IFormaGeometrica
{
   public double LadoA { get; set; }
   public double LadoB { get; set; }
   public double LadoC { get; set; }

    public double Area()
    {
      double SemiP = Perimetro() / 2.0;
      double expression = SemiP * (SemiP - LadoA) * (SemiP - LadoB) * (SemiP - LadoC);
      return Math.Sqrt(expression);
    }

    public double Perimetro()
    {
      return LadoA + LadoB + LadoC;
    }
}
