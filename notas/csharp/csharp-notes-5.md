# Melhorias na POO

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  public void DizerOi() {
    Console.WriteLine("Oi!");
  }
}
```

problemas dessa abordagem:

- Nao estou cuidado da criacao da classe, isto é, não estou cuidado de atributos que deveriam obrigatórios.

- Eu nao me preocupo com a maneira com que meus atributos sao utilizados

## Construtores

Construtores sao metodos que sao chamados durante a inicializacao do objeto.

```cs
Pessoa joao = new Pessoa();
```

implicitamente esta chamando:

```cs
public class Pessoa {
  // atributos...

  // construtor padrao
  public Pessoa() {
  }

  // metodos...
}
```

### construtores personalizados

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // all args constructor = construtor com todos os atributos
  public Pessoa(string nome, int idade, double altura) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

```cs
Pessoa joao = new Pessoa("Joao da Silva", 22, 1.8);
// joao.nome = "Joao da Silva";
// joao.idade = 22;
// joao.altura = 1.8;

joao.DarBoasVindas();
// imprimir: Bem vindo, me chamo joao da silva
```

### palavra-chave `this`

O `this` permite que a gente acesse o objeto responsavel por chamar o metodo.

- palavra diferenciadora
- palavra this faz a gente pensar no objeto

### Construtor que pensa

```cs
public class Pessoa {
  public string nome;
  public string sobrenome
  public int idade;
  public double altura;
  public string telefone;

  public Pessoa(string nomeCompleto, int idade, double altura) {
    // nomeCompleto = Pedro Silva
    string[] nomes = nomeCompleto.Split(' ');
    // nomes = ['Pedro', 'Silva']
    this.nome = nomes[0]; // nome = Pedro
    this.sobrenome = nomes[1]; // nome = Silva
    this.idade = idade;
    this.altura = altura;
  }

  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

### Sobrecarga (Overload)

- Consequencia: Multiplos construtores

Quando eu tenho o mesmo nome(função) porém com uma assinatura(parametros e retorno) diferentes.

```cs
public void DizerOi() {
  Console.WriteLine("oi!");
}

public void DizerOi(string nome) {
  Console.WriteLine($"oi, {nome}!");
}

public double Somar(double a, double b) {
  return a + b;
}

public double Somar(double a, double b, double c) {
  return a + b + c;
}
```

sobrecarga de construtores:

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // all args constructor = construtor com todos os atributos
  public Pessoa(string nome, int idade, double altura, string telefone) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
    this.telefone = telefone;
  }

  public Pessoa(string nome, int idade, double altura) {
    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  public Pessoa() {
  }

  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

reaproveitando os construtores

```cs
public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // all args constructor = construtor com todos os atributos
  public Pessoa(string nome, int idade, double altura) {
    if(idade <=0){
      throw new Exception("Idade invalida");
    }

    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }

  public Pessoa(string nome, int idade, double altura, string telefone) : 
    this() {
    this.telefone = telefone;
  }


  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }
}
```

## Modificadores de acesso

- visibilidade

|Modificador| Objetivo|
|:-:| :-: |
|`public`|pode ser acessado em qualquer pasta, ou arquivo da solucao|
|`private`|nao pode ser acessado em nenhum lugar fora da classe declarada|
|`protected`|so pode ser acessado na propria classe e nas classes filhas|
|`(default)`|pode ser acessado em qualquer lugar da mesma pasta/nivel|

exemplo do `(default)`:

`Projeto.Model.Pessoa.cs:`

```cs
class Pessoa {
  // ...
}
```

qualquer outra classe dentro do pacote `Model` poderia ver a classe `Pessoa`.

## Como estamos utilizando a nossa classe

```cs
public class Pessoa {

  // outros atributos
  public int idade;

  // construtor

}
```

nao quero que aconteça:

```cs
Pessoa joao = new Pessoa("Joao da Silva", 22, 1.8);

joao.idade = -1000;
```

evitando isso:

```cs
public class Pessoa {

  // outros atributos
  private int idade;

  // construtor

}
```

## Properties (Property)

- nao armazena valor
- pode fornecer acesso a valores de com uma sintaxe melhor

```cs
public double Altura {
  get {
    //sera chamado quando for acessar
  }
  set {
    // sera chamado quando for mudar
  }
}
```
