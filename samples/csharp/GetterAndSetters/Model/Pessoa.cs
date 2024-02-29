namespace GetterAndSetters.Model;

public class Pessoa
{
  public string Nome { get; set; }
  public int Idade { get; private set; }
  public double Altura { get; set; }
  public double Peso { get; set; }

  public Pessoa(string nome, int idade, double altura, double peso)
  {
      Nome = nome;
      Idade = idade;
      Altura = altura;
      Peso = peso;
  }

  public double IMC {
    get {
      return Peso / (Altura * Altura);
    }
  }

}
