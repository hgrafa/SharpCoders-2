namespace AbstractClasses.Model;

public class Retangulo : FormaGeometrica
{
   public double Comprimento { get; set; }
   public double Altura { get; set; }

   public override double Area() {
      return Comprimento * Altura;
   }

   public override double Perimetro() {
      return 2 * Comprimento + 2 * Altura;
   }
}
