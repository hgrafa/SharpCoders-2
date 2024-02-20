namespace AbstractClasses.Model;

public class Circulo : FormaGeometrica
{
   private static readonly double PI = 3.14159265;
   public double Raio { get; set; }

   public override double Area() {
      return PI * Raio * Raio;
   }

   public override double Perimetro() {
      return 2* PI * Raio;
   }
}
