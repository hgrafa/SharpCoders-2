using GetterAndSetters.Model;

Pessoa alice = new Pessoa("Alice da Silva", 1.7, 23);

// nao funciona :)
// alice.idade = -1000;
alice.SetAltura(-1.69);

Console.WriteLine(alice.nome);
Console.WriteLine(alice.GetAltura());
Console.WriteLine(alice.GetIdade());
