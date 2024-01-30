using bytebank.Domain.Enums;

namespace bytebank.Domain.Model;

public class Transaction
{
   public double Amount { get; set; } // quantia
   public TransactionType TransactionType { get; set; } // esta vindo
}