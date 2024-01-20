namespace Nullables;

public class Program
{
  public static void Main(string[] args)
  {
      double valor = double.Parse(Console.ReadLine()!);

      int? nota = null;

      Console.WriteLine(nota);

      double? salarioTrabalhoVoluntario = null;
      double? salarioSemTrabalho = 0.0;

      // trabalho voluntario = recebe 0 reais
      Console.WriteLine(salarioTrabalhoVoluntario ?? 0.0);

      // salario sem trabalho = recebe 0 reais
      Console.WriteLine(salarioSemTrabalho ?? 0.0);
  }

}