using System;

public class Program {
  public static void Main() {

    int quantidade = 0;
    double soma = 0;

    for(int _ = 0; _ < 6; _++) {
      double valor = double.Parse(Console.ReadLine());

      if(valor > 0) {
        quantidade++;
        soma += valor;
      }
    }

    double media = soma / quantidade;

    Console.WriteLine($"{quantidade} valores positivos");
    Console.WriteLine($"{media:F1}");

  } 

}