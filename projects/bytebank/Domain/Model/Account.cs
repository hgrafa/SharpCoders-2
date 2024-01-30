namespace bytebank.Domain.Model;

public class Account
{
   public string Holder { get; set; } // responsavel
   public double Balance { get; set; } // saldo
   public Transaction[] Transactions { get; set; }
}
