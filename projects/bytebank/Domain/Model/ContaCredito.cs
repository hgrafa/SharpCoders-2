namespace bytebank.Domain.Model;

public class ContaCredito : Conta
{
  private static readonly Random _random = new();
  public readonly double LimiteTotal = _random.Next(100, 1000);
  public double LimiteAtual { get; private set; }

  public ContaCredito() {
    LimiteAtual = LimiteTotal;
  }

  private bool UtilizouLimite() {
    return LimiteAtual != LimiteTotal;
  }

  public override void Depositar(double quantia) {
    if(UtilizouLimite()) {

    
    } else {
      if(quantia <= Saldo) { // nao utilizou e nao precisa do limite
        base.Depositar(quantia);
      } else {
        // DepositoTotal = 300
        // Devendo = LimiteTotal - LimiteAtual // 200
        // DepositoSaldo = DepositoTotal - Devendo; // 100
        // DepositoLimite = DepositoTotal - DepositoSaldo; // 200
        double saqueDoLimite = quantia - Saldo;
        double saqueDoSaldo = quantia - saqueDoLimite;


        Saldo -= saqueDoSaldo; // preciso descobrir quanto da quantia cabe no saldo

      }
    }
  }

  // Limite: 500, Saldo = 200, SaqueTotal = 300;
  // SaqueDoLimite = SaqueTotal - Saldo // 100
  // SaqueDoSaldo = SaqueTotal - SaqueDoLimite // 200
}
