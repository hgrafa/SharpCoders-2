using System;

namespace DistanciaEntreDoisPontos_1015;

public class Program {
  public static void Main() {

    string[] entradas = Console.ReadLine().Split(' ');

    double x1 = double.Parse(entradas[0]);
    double y1 = double.Parse(entradas[1]);

    entradas = Console.ReadLine().Split(' ');

    double x2 = double.Parse(entradas[0]);
    double y2 = double.Parse(entradas[1]);

    double diferenca_x = x2 - x1;
    double diferenca_y = y2 - y1;

    double distancia = Math.Sqrt(diferenca_x*diferenca_x + diferenca_y*diferenca_y);

    Console.WriteLine($"{distancia:F4}");
  }
}