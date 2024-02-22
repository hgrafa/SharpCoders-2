# Temas "extras"

## Manipulando arquivos

lendo linhas de um arquivo:

caminho relativo: `/teste`
caminho absoluto: `C:/dev/teste`

```cs
string basepath = @"/arquivos"
string filepath = $"{basepath}/teste.txt";

if (File.Exists(filepath)) { // checa se o arquivo existe


  string[] lines = File.ReadAllLines(filepath);

  foreach(string line in lines) {
    Console.WriteLine(line);
  }

}
```

## Exception

- tratar (`try...catch...finalyy`)
- delegar (`throw new Exception()`)
- criar (`MyException : Exception`)
