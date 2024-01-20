namespace RefInOutKeywords;

public class Program {

  public static void Troca(ref int a, ref int b) {
    int aux = a;
    a = b;
    b = aux;
  }

  public static void Imprime(in double valor) {
    // consigo garantir imutabilidade da variavel
    // valor = 200.0; // nao funciona
    Console.WriteLine($"Valor: R${valor:F2}");
  }

  public static void Inicializa(out int pontuacao) {
    pontuacao = 100;
  }

  public static void Main(string[] args)
  {
    int a = 3, b = 2;
    Console.WriteLine($"A: {a}, B: {b}"); // A: 3, B: 2

    Troca(ref a, ref b);

    Console.WriteLine($"A: {a}, B: {b}"); // A: 2, B: 3

    double valor = 239.99;
    Imprime(in valor);

    // int pontuacao;
    Inicializa(out int pontuacao);
    Console.WriteLine(pontuacao);
  }
}