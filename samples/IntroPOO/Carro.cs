namespace IntroPOO;

public class Carro
{ 
  public string placa;
  public string dono;
  public int ano;
  public string cor;
  public string modelo;
  public double combustivelEmLitros = 20;

  public void Abastecer(double quantidadeEmLitros) {
    combustivelEmLitros += quantidadeEmLitros;
  }

  public void GastarCombustivel(double quantidadeEmLitros) {
    combustivelEmLitros -= quantidadeEmLitros;
  }

}
