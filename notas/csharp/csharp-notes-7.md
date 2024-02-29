## Modificador `params`

jeito mais intuitivo:

```cs
public double Somar(double[] vetor) {
  double soma = 0;

  foreach(double valor in vetor) {
    soma += valor;
  }

  return soma;
}

// double[] numeros = {1, 2, 3};
// Somar(numeros);

Somar(new double[] {1, 2, 3})
```

alternativa:

```cs
public double Somar(double a, double b) {
  return a + b;
}

public double Somar(double a, double b, double c) {
  return a + b + c;
}

public double Somar(double a, double b, double c, double d) {
  return a + b + c + d;
}

Somar(1, 2, 3);
```

usando `params`:

```cs
public double Somar(params double[] vetor) {
  double soma = 0;

  foreach(double valor in vetor) {
    soma += valor;
  }

  return soma;
}

Soma(1, 2, 3);
```

## `foreach` - enhanced for

```cs
string[] fruits = {'apple', 'banana', 'watermelon'}

foreach(string fruit in fruits) {
  Console.WriteLine(fruit);
}
```

possivel problema (de vez em quando):

problematicas:

- value atua como uma cópia da informação
- alterar value não altera o array

```cs
int[] array = new int[1000];

foreach(int value in array) {
  // int value = array[i]
  value = -1;
}
```

# Listas

Coisas comuns:

- Ambos sao homogeneos (so guardam elementos do mesmo tipo)
- Sao indexados em zero.

```
[Guitarra, Guitarra, Bateria, Microfone, Guitarra]
[Instrumento, Instrumento, Instrumento, Instrumento, Instrumento]
```

vantagens:

- Lista nao tem tamanho definido.
- Lista aloca sob demanda.
- Metodos utilitarios.

```cs
List<int> meusInteiros = new List<int>();
```

## Principais metodos

adicionando:

```cs
meusInteiros.Add(1);
meusInteiros.Add(2);
meusInteiros.Add(3);
meusInteiros.Add(4);

meusInteiros.Insert(0, 0);
```

contando elementos:

```cs
Console.WriteLine($"tamanho da lista: {meusInteiros.Count}");
```

find, findLast, findIndex, findLastIndex:

```cs

List<Pessoa> pessoas = new() {
  new() { Nome = "João", Idade = 20, Altura = 1.80, TemHabilitacao = false },
  new() { Nome = "Pedro", Idade = 16, Altura = 1.80, TemHabilitacao = true },
  new() { Nome = "Maria", Idade = 25, Altura = 1.60, TemHabilitacao = false },
  new() { Nome = "Alice", Idade = 23, Altura = 1.60, TemHabilitacao = true },
  new() { Nome = "Marcio", Idade = 23, Altura = 1.60, TemHabilitacao = true },
};

// Pessoa? pessoaHabilitada = pessoas.Find(pessoa => pessoa.TemHabilitacao == true);
Pessoa? pessoaHabilitada = pessoas.FindLast(pessoa => pessoa.TemHabilitacao == true);
pessoas.FindIndex((pessoa) => pessoa.Idade >= 23);
pessoas.FindLastIndex((pessoa) => pessoa.Idade >= 23);
```

where:

```cs
List<Pessoa> pessoasMaioresDeIdadeEHabilitadas = pessoas
  .Where(pessoa => pessoa.Idade >= 18)
  .Where(pessoa => pessoa.TemHabilitacao == true)
  .ToList();

Console.WriteLine("Pessoas maiores de idade e habilitadas: ");
foreach(var pessoaMaiorDeIdadeEHabilitada in pessoasMaioresDeIdadeEHabilitadas){
  Console.WriteLine(pessoaMaiorDeIdadeEHabilitada);
}
```

## Design

- Model/Domain: Dominio do produto
- Service: regras do negocio/"acessar" os dados
- View/(Menu): isola as interacoes com o usuario
