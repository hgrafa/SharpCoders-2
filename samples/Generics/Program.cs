using Generics;
using Generics.Model;

IntermediadorDeMensagens<string> intermediadorTextos = new();
IntermediadorDeMensagens<Pessoa> intermediadorDePessoas = new();

intermediadorTextos.Acumular("oi");

intermediadorDePessoas.Acumular(new Pessoa() {
  Nome = "Joao da Silva",
  Idade = 25,
});

intermediadorDePessoas.Acumular(new Funcionario() {
});