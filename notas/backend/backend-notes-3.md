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

  public virtual List<PessoaHabilidade> Habilidades {get; set;}
}

public class PessoaHabilidade: Entity {

  public int? PessoaId {get; set;}
  public virtual Pessoa Pessoa {get; set;}

  public int? HabilidadeId {get; set;}
  public virtual Habilidade Habilidade {get; set;}

}

public class Habilidade : Entity {

  public string Nome {get; set;}
  
  public int? PessoaId {get; set;}
  public virtual Pessoa Pessoa {get; set;}
  
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
