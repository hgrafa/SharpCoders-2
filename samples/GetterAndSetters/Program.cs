using GetterAndSetters.Model;

Pessoa alice = new Pessoa("Alice da Silva", 1.7, 60, 23);

// nao funciona :)
// alice.idade = -1000;
alice.Altura = 1.69;
// alice.Idade = 10;

Console.WriteLine(alice.nome);
Console.WriteLine(alice.Altura);
Console.WriteLine(alice.Idade);
Console.WriteLine($"{alice.IMC:F2}");
