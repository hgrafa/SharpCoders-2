namespace FibonacciEmVetor_1176;

public class Program
{
  static void Main(string[] args)
  {

    ulong[] fib = new ulong[70];
    int nTestes = int.Parse(Console.ReadLine());

    // valores iniciais
    fib[0] = 0;
    fib[1] = 1;

    for (int _ = 0; _ < nTestes; _++)
    {

      int n = int.Parse(Console.ReadLine());

      // TODO: melhorar percorrendo apenas os valores ainda nao calculados
      for(int i = 2; i <= n; i++) {
        fib[i] = fib[i-1] + fib[i-2];
      }

      Console.WriteLine($"Fib({n}) = {fib[n]}");
    }

  }
}