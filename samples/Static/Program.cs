using Static.Entities;
using Static.Utils;

public class Program {
  
  public static void Main() {
    Circulo c1 = new() { Raio = 10 };

    Console.WriteLine(Circulo.PI);
    Console.WriteLine(c1.Area);
    Console.WriteLine(c1.Perimetro);


    Console.WriteLine("---------");

    Console.WriteLine( CirculoUtils.CalculateArea(10) );
    Console.WriteLine( CirculoUtils.CalculatePerimetro(10) );
  }

}

// Program.Main()