namespace GetterAndSetters.Model;

public class Pessoa
{
  private int _idade;
  private double _altura;
  private double _peso;
  public string nome;

  public Pessoa(string nome, double altura, double peso, int idade)
  {
      this.nome = nome;
      _altura = altura;
      _idade = idade;
      _peso = peso;
  }

  public double Altura {
    get {
      return _altura;
    }
    set {
      if(value < 0) {
        throw new Exception("A altura deve ser positiva");
      }

      _altura = value;
    }
  }

  public int Idade {
    get {
      return _idade;
    }
  }

  public double IMC {
    get {
      return _peso / (_altura * _altura);
    }
  }

  // public void SetAltura(double altura) {
  //   if(altura < 0) {
  //     throw new Exception("A altura deve ser positiva");
  //   }

  //   _altura = altura;
  // }

  // public int GetIdade() {
  //   return _idade;
  // }

  // public double GetAltura() {
  //   return _altura;
  // }

}
