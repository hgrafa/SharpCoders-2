
using bytebank.Domain.Model;

Conta c1 = new () { Responsavel = "Pedro da Silva" };
Conta c2 = new () { Responsavel = "Maria da Silva" };

c1.Depositar(1000);
c1.Sacar(200);

c2.Depositar(500);

c1.Transferir(100, c2); // c2: 600, c1: 700

Console.WriteLine(c1);
Console.WriteLine(c2);