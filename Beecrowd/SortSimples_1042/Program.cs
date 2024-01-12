using System;

public class Program {

  public static void Main() {

    string[] entradas = Console.ReadLine().Split(' ');
    int a =int.Parse(entradas[0]);
    int b =int.Parse(entradas[1]);
    int c =int.Parse(entradas[2]);

    int menor, meio, maior;

    if(a < b && a < c){
      Console.WriteLine(a);

      if(b < c) {// a < b < c
        Console.WriteLine(b);
        Console.WriteLine(c);
      } else { // a < c < b
        Console.WriteLine(c);
        Console.WriteLine(b);
      }
    } else if (b < a && b < c){ 
      Console.WriteLine(b);

      if(a < c) { // b < a < c
        Console.WriteLine(a);
        Console.WriteLine(c);
      } else {
        Console.WriteLine(c);
        Console.WriteLine(a);
      }
    } else {
      Console.WriteLine(c);

      if(a < b) { // c < a < b
        Console.WriteLine(a);
        Console.WriteLine(b);
      } else { // c < b < a
        Console.WriteLine(b);
        Console.WriteLine(a);
      }
    }

    Console.WriteLine();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);

  }

}
