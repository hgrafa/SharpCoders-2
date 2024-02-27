# Temas "extras"

## Manipulando arquivos

lendo linhas de um arquivo:

caminho relativo: `/teste`
caminho absoluto: `C:/dev/teste`

```cs
string basepath = @"/arquivos"
string filepath = $"{basepath}/teste.txt";

if (File.Exists(filepath)) { // checa se o arquivo existe


  string[] lines = File.ReadAllLines(filepath);

  foreach(string line in lines) {
    Console.WriteLine(line);
  }

}
```

## Exception

- tratar (`try...catch...finaly`)

```cs
try {
  // codigo que podia dar erro e lancar alguma exception
} catch (NullReferenceException e1) {
  Console.WriteLine(e1.Message);
} catch(/*...*/) {
  // ...
} finally { // finalmente
  // codigo que roda independente de ter dado alguma exception
}
```

```cs
try {
  // ...
} catch (Exception e) when (e is NullReferenceException || e is InvalidOperationException) {

}
```

- delegar (`throw new Exception()`)

`throw`: siginfica *arremesse*

```cs
static double Divide(double a, double b) {
  if(b == 0) {
    throw new ArgumentException("O denominador deve ser diferente de zero");
  }

  return a / b;
}

static void Main() {
  try {
    divide(2, 0);
  } catch(ArgumentException exception) {
    Console.WriteLine(exception.Message);
  }
}
```

- criar (`MyException : Exception`)

```cs
public class SaldoInsuficienteException : Exception {

  public SaldoInsuficienteException() {
  }

  public SaldoInsuficienteException(string message) : base(message) {
  }
}

new Exception("Comportamento inesperado");
new SaldoInsuficienteException("Comportamento inesperado");
```
