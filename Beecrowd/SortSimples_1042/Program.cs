using System;

public class Program {

  public static void Main() {

    string[] entradas = Console.ReadLine().Split(' ');
    int a = int.Parse(entradas[0]);
    int b = int.Parse(entradas[1]);
    int c = int.Parse(entradas[2]);

    int x = a; // 1
    int y = b; // 2
    int z = c; // 3

    // int a = 2, b = 3; // a = 2, b = 3
    // int temp = a; // a = 2, b = 3, temp = 2
    // a = b; // a = 3, b = 3, temp = 2
    // b = temp; // a = 3, b = 2, temp = 2

    if(y > z) {
      int aux = y;
      y = z;
      z = aux;
    }

    if(x > y) {
      int aux = x;
      x = y;
      y = aux;
    }

    if(y > z) {
      int aux = y;
      y = z;
      z = aux;
    }

    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
    Console.WriteLine();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);

  }

}
