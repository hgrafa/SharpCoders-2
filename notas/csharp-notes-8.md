# Aprofundando em  POO

## Atributos e Metodos estaticos

```cs
public class Circulo {
  public readonly double PI = 3.14159265;

  public double Raio {get; set;}

  public double Area {
    get { return PI * Raio * Raio; }
  }

  public double Perimetro {
    get { return 2 * PI * Raio; }
  }
}
```

problemas:

- Cada circulo esta tendo o seu proprio PI
- Eu deveria conseguir saber o valor de PI independente de um objeto Circulo

**Static** (estatico):

```cs
public class Circulo {
  public static readonly double PI = 3.14159265;

  public double Raio {get; set;}

  public double Area {
    get { return PI * Raio * Raio; }
  }

  public double Perimetro {
    get { return 2 * PI * Raio; }
  }
}
```

- serve para criar variavel global
- seria compartilhado entre todos (nao gastaria memoria adicional)
- nao depende de um objeto para ser utilizado, passaria a funcionar:

```cs
  Console.WriteLine(Circulo.PI); // 3.1415...
```

```cs
Math.Log10();
```

```cs
public class TimeUtils {
  public static readonly double DAY_IN_HOURS = 24.0;
  public static readonly double DAY_IN_MINUTES = 24.0 * 60.0;
}
```

se eu estivesse num programa onde nao quero instanciar circulos, apenas isolar calculos dentro de uma classe

```cs
public class CircleUtils {

  private static readonly double PI = 3.14159265;

  public static double CalculateArea(double raio) {
    return PI * Raio * Raio;
  }

  public static double CalculatePerimetro(double raio) {
    return 2 * PI * Raio;
  }

}
```

usando:

```cs
double result = CircleUtils.CalculateArea(3.0);
```

## Herança

a herança é permitir que uma classe extenda comportamentos e atributos de outra, para que sejam reaproveitados.

- tem um / tem varios = atributo ou property
- faz ou um comportamento = metodo
- é um, é uma = herança

```
Pessoa
- Estudante
- Professor
```

```cs
public class Pessoa {
  public string Nome {get; set;}
  public string Cpf {get; set;}
  public string Idade {get; set;}
}

public class Estudante : Pessoa { // Estudante extende Pessoa
  // public string Nome {get; set;}
  // public string Cpf {get; set;}
  // public string Idade {get; set;}
  public string RegistroDoAluno {get; set;}
}

public class Professor : Pessoa { // Professor extende Pessoa
  // public string Nome {get; set;}
  // public string Cpf {get; set;}
  // public string Idade {get; set;}
  public List<string> Habilidades {get; set;} = new();
}
```

## Keywords (palavras-chave) de heranca

### base

A palavra `base` funciona de modo similar a palavra `this`, so que ela faz referencia a classe mae do metodo ou atributo sendo utilizado.

### `virtual`

Permite que um metodo seja sobreescrito por uma classe filha

### `override` - sobreescrever

se eu quero mudar o comportamento de um metodo da classe mae.

exemplo: sobreescrevendo o comportamento padrao da classe `Object`

```cs
public override string ToString()
{
    return $"...";
}
```

### protected

permite que classes filhas e a classe mae vejam um atributo.
