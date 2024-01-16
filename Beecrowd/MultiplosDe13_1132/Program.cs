namespace MultiplosDe13_1132;

public class Program {

  static bool IsMultiplo13(int number) {
    return number%13 == 0;
  }

  static int SomaIntervalo(int inicio, int fim) {
    // calcula pela soma da PA
    return 0;
  }

  public static void Main(string[] args)
  {
    // quero = tudo - {nao quero}
    // quero = a soma dos que nao sao mult 13
    // tudo = somar tudo
    // nao quero = soma dos multiplos 13

    // 10 15 = 10 + 11 + 12 + 13 + 14 + 15 - 13

    int inicio = int.Parse(Console.ReadLine());
    int fim = int.Parse(Console.ReadLine());

    if(inicio > fim) {
      int aux = inicio;
      inicio = fim;
      fim = aux;
    }

    int soma = 0;

    for(int i = inicio; i <= fim; i++) {
      if(!IsMultiplo13(i))
        soma += i;
    }

    Console.WriteLine(soma);
  }

}