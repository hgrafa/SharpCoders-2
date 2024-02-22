using Exceptions.Exceptions;

static double[] LerDoisNumeros() {
  double a = double.Parse(Console.ReadLine()!);
  double b = double.Parse(Console.ReadLine()!);

  if(a < 0 || b < 0)
    throw new NumeroInvalidoException("Numero nao pode ser usado neste programa");

  return new double[] {a, b};
}

static double Dividir(double a, double b) {
  if(b == 0) {
    throw new DivideByZeroException("vc nao pode dividir por zero");
  }

  return a / b;
}

static double ResolveDivisao() {
  double[] entradas = LerDoisNumeros();  

  double a = entradas[0];
  double b = entradas[1];

  return Dividir(a, b);
}

try {
  Console.WriteLine(ResolveDivisao());
} catch (Exception exception) when (exception is FormatException || exception is ArgumentNullException) {
  Console.WriteLine("Algum numero parece incorreto");
} catch (DivideByZeroException) {
  Console.WriteLine("Nao eh possivel dividir por zero");
} finally {
  Console.WriteLine("fim da funcao 3");
}

Console.WriteLine("meu programa continuou rodando...");

static double AreaCirculo(double raio) {
  try {
    // abro conexao
    if(raio <= 0) 
      throw new NumeroInvalidoException("raio precisa ser positivo");

    // faco algo

    // fecho

    return raio * raio * 3.1415;
  } catch (NumeroInvalidoException) {
    Console.WriteLine("Parece que foi digitado um numero invalido");

    return 0;
  } finally {
    Console.WriteLine("Fim da funcao Area");
  }
}