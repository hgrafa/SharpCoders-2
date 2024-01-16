# Funções

##

Conjunto de passos bem definidos.

podem ter...

- retorno
- parametros, entradas, argumento

- calculos matematicos

```cs
//f(x) = x + 2
static double SomarDois(double x) {
  return x + 2;
}

// void = vazio
static void SayHello() {
  Console.WriteLine("Hello!");
  return;
}

static void SayHelloToSomeone(string name) {
  Console.WriteLine($"Hello, {name}");
}

// boolean = prefixo Is e Has
// even = Par
static boolean IsEven(int num) {
  return num%2 == 0;
}

static boolean HasInvalidCharacters(string username) {
  // logica para validar se o username esta com caracteres invalidos
}

public static void Main() {
  
  string username = Console.ReadLine();

  if(HasInvalidCharacters(username)) {
    // faz algo com o username
  }

  Console.WriteLine(SomarDois(5));
}
```

menção honrosa:

- valor em detrimento de outro
- execucao de processos
- reaproveitamento (reuso, e se codigo fosse muito grande)
- instrucao isolada/divisao de tarefas
- utilidade
- modularizacao/bloco de codigo
- objetivo/resolve problemas
- Legibilidade

## Fibonacci

cada próximo termo é a soma dos 2 anteriores a ele
valores = 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
indices = 0, 1, 2, 3, 4, 5, 6,  7,  8,  9, 10, 11
