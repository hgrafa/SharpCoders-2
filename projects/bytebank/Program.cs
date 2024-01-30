
using bytebank.Domain.Enums;
using bytebank.Domain.Model;

Transaction[] randomTransactions = new Transaction[] {
    new Transaction {
      Amount = 100,
      TransactionType = TransactionType.DEPOSIT
    },
    new Transaction {
      Amount = 50,
      TransactionType = TransactionType.WITHDRAW
    },
    new Transaction {
      Amount = 10,
      TransactionType = TransactionType.DEPOSIT
    }
  };

Account account = new Account {
  Holder = "Hugo",
  Balance = 1,
  Transactions = randomTransactions
};

// const user = {
//   name: 'Hugo',
//   age: 36,
//   streetOfAddress: 'Rua X',
//   numberOfAddress: 123
// }