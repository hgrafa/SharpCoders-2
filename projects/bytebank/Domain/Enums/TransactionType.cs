namespace bytebank.Domain.Enums;

public enum TransactionType {
  WITHDRAW, // saque
  DEPOSIT, // deposito
  TRANSFER // transferencia
}

public enum TransactionDirection {
  INCOME,
  OUTCOME
}