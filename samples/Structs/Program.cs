namespace Structs;

public struct Pessoa {
   public string Nome;
   public int Idade;
   public double Altura;
   public string NumeroDeTelefone;
}

public struct Point {
   public int X;
   public int Y;
}

public struct Number{
   public double real;
   public double imaginary;
}

public class Program
{
   public static void Main()
   {
      Pessoa p;

      p.Nome = "João";
      p.Idade = 18;

      Console.WriteLine(p.Nome);
      Console.WriteLine(p.Idade);
      

   }
}
