using GetterAndSetters.Model;

Pessoa alice = new Pessoa("Alice da Silva", 23, 1.7, 60.0);

// nao funciona :)
// alice.idade = -1000;
alice.Altura = 1.69;
// alice.Idade = 10;

Console.WriteLine(alice.Nome);
Console.WriteLine(alice.Altura);
Console.WriteLine(alice.Idade);
Console.WriteLine($"{alice.IMC:F2}");
