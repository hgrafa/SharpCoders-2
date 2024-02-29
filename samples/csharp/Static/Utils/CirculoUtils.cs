namespace Static.Utils;

public class CirculoUtils {

  private static readonly double PI = 3.14159265;

  public static double CalculateArea(double raio) {
    return PI * raio * raio;
  }

  public static double CalculatePerimetro(double raio) {
    return 2 * PI * raio;
  }
 
}
