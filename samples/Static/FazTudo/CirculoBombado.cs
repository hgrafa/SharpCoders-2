namespace Static.FazTudo;

public class CirculoBombado {
  public static readonly double PI = 3.14159265;

  public double Raio {get; set;}

  public double Area {
    get { return PI * Raio * Raio; }
  }

  public double Perimetro {
    get { return 2 * PI * Raio; }
  }

  public static double CalculateArea(double raio) {
    return PI * raio * raio;
  }

  public static double CalculatePerimetro(double raio) {
    return 2 * PI * raio;
  }
}