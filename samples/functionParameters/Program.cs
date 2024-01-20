public class Program {

  static double DeveriaSomar(double a, double b) {
    Troca(a, b);
    return  a - b;
  }

  static double Atrapalha(double x, double y) {
    return DeveriaSomar(x, y);
  }

  static void Troca(double a, double b) {
    double aux = a;
    a = b;
    b = aux;
    Console.WriteLine($"a = {a}, b = {b}");
  }

  public static void Main() {
    Console.WriteLine(Atrapalha(2.5, 1.5));
  }

}