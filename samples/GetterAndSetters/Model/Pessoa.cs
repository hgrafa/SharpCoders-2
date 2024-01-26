namespace GetterAndSetters.Model;

public class Pessoa
{
  private int _idade;
  private double _altura;
  public string nome;

  public Pessoa(string nome, double altura, int idade)
  {
      this.nome = nome;
      _altura = altura;
      _idade = idade;
  }

  public int GetIdade() {
    return _idade;
  }

  public double GetAltura() {
    return _altura;
  }

  public void SetAltura(double altura) {
    if(altura < 0) {
      throw new Exception("A altura deve ser positiva");
    }

    _altura = altura;
  }
}
