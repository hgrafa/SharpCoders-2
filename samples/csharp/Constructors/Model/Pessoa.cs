namespace Constructors.Model;

public class Pessoa {
  public string nome;
  public int idade;
  public double altura;
  public string telefone;

  // heranca = este construtor extende o construtor
  public Pessoa(string nome, int idade, double altura, string telefone) 
    : this(nome, idade, altura) {
    this.telefone = telefone;
  }

  // all args constructor = construtor com todos os atributos
  public Pessoa(string nome, int idade, double altura) {
    if(idade <=0){
      throw new Exception("Idade invalida");
    }

    this.nome = nome;
    this.idade = idade;
    this.altura = altura;
  }
  
  public void DarBoasVindas() {
    Console.WriteLine($"Bem vindo, me chamo {nome}!");
  }

  public void TestaMetodos() {
    DarBoasVindas();
  }
}