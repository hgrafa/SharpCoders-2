# Melhorando herança

## Generics

- Objetivo: Criar um acumulador e disparador de mensagens, valores, objetos, etc.
- Descricao: Acumular(Informacao) -> essa informacao deve ser guardada.
- Descricao: Disparar() -> exibir todas as informacoes de uma unica vez em tela.

```cs
public class IntermediadorDeMensagens {

  public List<string> Mensagens = new() {get; private set;}

  public void Acumular(string mensagem) {
    Mensagens.Add(mensagem);
  }

  public void Disparar() {
    foreach(string mensagem in Mensagens) {
      int currentPositionToRemove = 0;
      Console.WriteLine(mensagem);
      Mensagens.RemoveAt(currentPositionToRemove);
    }
  }

}
```

problemas:

- se eu quisesse lidar com numeros, teria que recriar a classe para numeros.
- se eu quisesse lidar com pessoas, teria que recriar a classe para pessoas.

> codigo ruim: ruim de entender, extender e mudar

### relembrando

upcasting:

```cs
Pessoa pedro = new Aluno(); // pedro eh um aluno e todo aluno eh tambem uma pessoa
FormaGeometrica circulo = new Circulo(); // mesma ideia
```

downcasting:

```cs
Pessoa pessoa = new Aluno();

// deixando downcasting seguro
if (pessoa is Aluno aluno) {
  // Aluno a = (Aluno) p;
  aluno.Nota = 10.0;
}
```

consequencia:

```cs
Object a = new Pessoa();
Object b = new Aluno();
Object c = new Quadrado();
```

### melhorando com Object

```cs
public class IntermediadorDeMensagens {

  public List<Object> Mensagens = new() {get; private set;}

  public void Acumular(Object mensagem) {
    Mensagens.Add(mensagem);
  }

  public void Disparar() {
    foreach(Object mensagem in Mensagens) {
      int currentPositionToRemove = 0;
      Console.WriteLine(mensagem);
      Mensagens.RemoveAt(currentPositionToRemove);
    }
  }

}
```

problemas:

- nao possuo seguranca dos tipos dos valores dentro do intermediador
- nao consigo garantir alguma chamada de metodo ou execucao especifica utilizando object

## Classes e ... abstratas

Classes abstratas sao classes feitas para serem extendidas e continuadas. Elas nao sao capazes de produzir um objeto.
