using System;

public class Program {
  public static void Main() {

    int n = int.Parse(Console.ReadLine());

    // n = 1 -> nao existe
    // n = 2 -> nao existe
    // n = 3 -> 2 eh primeiro
    // n > 3 -> 2 eh primeiro

    // n = 4 -> 2, 6, 10, 14

    if(n <= 2) {
      return;
    }
    
    for(int i = 2; i <= 10000; i += n) {
      Console.WriteLine(i);
    }
  }
}