# Relacionamos e Entity Framework

maneiras mais simples:

## um pra um

```cs
public class Pessoa: Entity {

  public string Nome {get; set;}
  public string Idade {get; set;}

  public int EnderecoId {get; set;}
  public virtual Endereco Endereco {get; set;}

}

public class Endereco : Entity {

  public string Rua {get; set;}
  public string Numero {get; set;}
  
}
```

## um pra n

```cs
public class Pessoa: Entity {

  public string Nome {get; set;}
  public string Idade {get; set;}

  public virtual List<Telefone> Telefones {get; set;}

}

public class Telefone : Entity {

  public string Ddi {get; set;}
  public string Ddd {get; set;}
  public string Numero {get; set;}

  
  public int? PessoaId {get; set;}
  public virtual Pessoa Pessoa {get; set;}
  
}
```

## n pra n

```cs
public class Pessoa: Entity {

  public string Nome {get; set;}
  public string Idade {get; set;}

  public virtual List<PessoaHabilidade> PessoaHabilidades {get; set;}
}

public class PessoaHabilidade: Entity {

  public int? PessoaId {get; set;}
  public virtual Pessoa Pessoa {get; set;}

  public int? HabilidadeId {get; set;}
  public virtual Habilidade Habilidade {get; set;}

}

public class Habilidade : Entity {

  public string Nome {get; set;}
  
  public virtual List<PessoaHabilidade> PessoaHabilidades {get; set;}
  
}
```

Pessoas

| Id |Nome | Idade|
| :-: | :-:|:-:|
| 2 |joao | 25 |

Habilidades

Pessoas
| Id |Nome |
| :-: | :-:|
| 1 | Futebol |
| 2 | Basquete |
| 3 | Skate |

Pessoas_Habilidades

| Id | Pessoa_Id | Habilidade_Id |
| :-: | :-: | :-: |
| 1 | 2 | 1|
| 2 | 2 | 3 |

## Fazendo pelo DbContext

```cs
public class AppDbContext: DbContext {

  public AppDbContext(options) : base(options) {
  }

  protected override ... OnModelCreating(ModelBuilder builder) {
    
    // 1 : 1
    builder.Entity<Pessoa>()
      .HasOne(pessoa => pessoa.Endereco)
      .WithOne(endereco => endereco.Pessoa)
      .HasForeignKey<Endereco>(endereco => endereco.PessoaId)

    // 1 : n
    builder.Entity<PessoaHabilidade>()
      .HasMany(pessoa => pessoa.Telefones)
      .WithOne(telefone => telefone.Pessoa)
      .HasForeignKey(telefone => telefone.PessoaId);

    // n : n
    builder.Entity<PessoaHabilidade>()
      .HasOne(pessoaHabilidade => pessoaHabilidade.Pessoa)
      .WithMany(pessoa => pessoa.pessoaHabilidades)
      .HasForeignKey(pessoaHabilidade => pessoaHabilidade.PessoaId);

    builder.Entity<PessoaHabilidade>()
      .HasOne(pessoaHabilidade => pessoaHabilidade.Habilidade)
      .WithMany(habilidade => habilidade.pessoaHabilidades)
      .HasForeignKey(pessoaHabilidade => pessoaHabilidade.HabilidadeId);
  }
}
```

## extension methods

```cs
public class StringExtension {


  public static int WordCount(this string text, int number) {
    return text.Split(' ').Length;
  }

}

string texto = "abc abc abc";


texto.WordCount();
```

## dependency injection

- scoped
- transient
- singleton

## Singleton

```cs
public class Path {

  public string AbsolutePath {get; set;}
  public string RelativePath {get; set;}

  private static Path? pathInstance = null;

  private Path() {
  }

  public Path GetInstance() {
    if(pathInstance != null) {
      return pathInstance;
    }

    return new Path();
  }

  public void Concatenate(Path path) {
    // ...
  }

}

Path p = Path.GetInstance();
```
