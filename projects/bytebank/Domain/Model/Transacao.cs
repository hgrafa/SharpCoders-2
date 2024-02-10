using bytebank.Domain.Enums;

namespace bytebank.Domain.Model;

public class Transacao {
  public readonly double Valor;
  public readonly TipoTransacao TipoTransacao;
  public readonly DirecaoTransacao DirecaoTransacao;

  public Transacao (
    double valor, 
    TipoTransacao tipoTransacao, 
    DirecaoTransacao direcaoTransacao
  ) {
    Valor = valor;
    TipoTransacao = tipoTransacao;
    DirecaoTransacao = direcaoTransacao;
  }

    public override string ToString()
    {
        return $"Transacao: {TipoTransacao}, Direcao: {DirecaoTransacao}, Valor: {Valor}";
    }

}