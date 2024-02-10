using bytebank.Domain.Enums;

namespace bytebank.Domain.Model;

public class Conta
{
  private static int _idContador = 1;
  public readonly int Id = _idContador++;
  public string Responsavel {get; set;}
  public double Saldo {get; protected set;}
  public bool EstaBloqueada { get; set; }
  public List<Transacao> Transacoes { get; private set; } = new();

  public virtual void Depositar(double quantia) {
    if(EstaBloqueada)
      return;

    Saldo += quantia;
    Transacoes.Add(new Transacao(quantia, TipoTransacao.DEPOSITO, DirecaoTransacao.ENTRADA));
  }

  public bool Sacar(double quantia) {
    if(quantia > Saldo) 
      return false;

    if(EstaBloqueada)
      return false;

    Saldo -= quantia;
    Transacoes.Add(new Transacao(quantia, TipoTransacao.SAQUE, DirecaoTransacao.SAIDA));
    return true;
  }

  public bool Transferir(double quantia, Conta contaDestino) {
    if(quantia > Saldo) 
      return false;

    if(EstaBloqueada)
      return false;

    if(contaDestino == null)
      return false;

    Saldo -= quantia;
    contaDestino.Saldo += quantia;
    Transacoes.Add(new Transacao(quantia, TipoTransacao.TRANSFERENCIA, DirecaoTransacao.SAIDA));
    contaDestino.Transacoes.Add(new Transacao(quantia, TipoTransacao.TRANSFERENCIA, DirecaoTransacao.ENTRADA));
    return true;
  }

  public override string ToString()
  {
      string aux = ""; // string builder 
      
      aux += $"Id: {Id}, Responsavel: {Responsavel}\n";

      if(EstaBloqueada)
        aux += $"### CONTA BLOQUEADA ###\n";

      aux += $"Saldo da Conta R${Saldo:F2}\n";

      aux += "------------------------------\n";

      if(Transacoes.Count == 0){
        aux += "Nao ha transacoes registradas";
      } else {
        Transacoes.ForEach(transacao => {
          aux += $"{transacao}\n";
        });
      }

      aux += "------------------------------\n";

      return aux;
  }
}
