// List<int> meusInteiros = new List<int>() { 1, 2, 3, 4 };

// // meusInteiros.Add(1);
// // meusInteiros.Add(2);
// // meusInteiros.Add(3);
// // meusInteiros.Add(4);

// meusInteiros.Insert(0, 999);

// int result = meusInteiros.Find(value => value == 6);

// Console.WriteLine("Busca: " + result);

// // meusInteiros.Where(value => value%2 == 0);

// for(int i = 0; i < meusInteiros.Count; i++){
//   Console.WriteLine(meusInteiros[i]);
// }

using Listas.Model;

List<Pessoa> pessoas = new() {
  new() { Nome = "João", Idade = 20, Altura = 1.80, TemHabilitacao = false },
  new() { Nome = "Pedro", Idade = 16, Altura = 1.80, TemHabilitacao = true },
  new() { Nome = "Maria", Idade = 25, Altura = 1.60, TemHabilitacao = false },
  new() { Nome = "Alice", Idade = 23, Altura = 1.60, TemHabilitacao = true },
  new() { Nome = "Marcio", Idade = 23, Altura = 1.60, TemHabilitacao = true },
};

// Pessoa? pessoaHabilitada = pessoas.Find(pessoa => pessoa.TemHabilitacao == true);
Pessoa? pessoaHabilitada = pessoas.FindLast(pessoa => pessoa.TemHabilitacao == true);
pessoas.FindIndex((pessoa) => pessoa.Idade >= 23);
pessoas.FindLastIndex((pessoa) => pessoa.Idade >= 23);

List<Pessoa> pessoasMaioresDeIdadeEHabilitadas = pessoas
  .Where(pessoa => pessoa.Idade >= 18)
  .Where(pessoa => pessoa.TemHabilitacao == true)
  .ToList();

Console.WriteLine("Pessoas maiores de idade e habilitadas: ");
foreach(var pessoaMaiorDeIdadeEHabilitada in pessoasMaioresDeIdadeEHabilitadas){
  Console.WriteLine(pessoaMaiorDeIdadeEHabilitada);
}

if(pessoaHabilitada != null){
  Console.WriteLine("Habilitado: " + pessoaHabilitada);
}

foreach(var pessoa in pessoas){
  Console.WriteLine(pessoa);
}