using System;

public class Program {

  public static void Main() {

    string[] entradas = Console.ReadLine().Split(' ');
    int a =int.Parse(entradas[0]);
    int b =int.Parse(entradas[1]);
    int c =int.Parse(entradas[2]);

    int menor = Math.Min(Math.Min(a, b), c);
    int maior = Math.Max(Math.Max(a, b), c);
    int meio;

    if(a != menor && a != maior)
      meio = a;
    else if(b != menor && b != maior)
      meio = b
    else 
      meio = c;

    Console.WriteLine(menor);
    Console.WriteLine(meio);
    Console.WriteLine(maior);
    Console.WriteLine();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);

  }

}
