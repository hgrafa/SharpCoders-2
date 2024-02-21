// string basepath = @"arquivos";
// string filename = "teste.txt";
// string filepath = Path.Combine(basepath, filename);

// Console.WriteLine($"Path: {filepath}");

// if (File.Exists(filepath)) { // checa se o arquivo existe

//   Console.WriteLine("file founded");

//   string[] lines = File.ReadAllLines(filepath);

//   foreach(string line in lines) {
//     Console.WriteLine(line);
//   }

// } else {

//   Console.WriteLine("file not founded");

// }

// using (StreamWriter writer = File.AppendText(filepath)) {
//   writer.WriteLine("estou escrevendo no arquivo");
// }

// using (StreamWriter writer = new(filepath)) {
//   writer.WriteLine("estou escrevendo no arquivo");
// }

using Arquivos.Repository;

StudentRepository studentRepository = new();

studentRepository
  .FindAll()
  .ForEach(student => Console.WriteLine(student));