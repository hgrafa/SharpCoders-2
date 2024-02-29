namespace Listas.Model;

public class Pessoa
{
  public string Nome { get; set; }
  public int Idade { get; set; }
  public double Altura { get; set; }
  public bool TemHabilitacao { get; set; }

  public override string ToString()
  {
    return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}, Habilitação: {(TemHabilitacao ? "Sim" : "Não")}";
  }
}
