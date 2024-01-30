# POO de um jeito pratico

## null assertion

o operador `null!` ou usar `!` para evitar warnings(avisos) de nulo, nao garante que o conteudo nao vira nulo, apenas indica que voce esta se responsabilizando que o conteudo nao sera nulo.

```cs
public class User
{
   public int Id { get; set; }
   public string Email { get; set; } = null!;
   public string Username { get; set; }
   public string? Nickname {get; set;} = null;
   public string Password { get; set; }
}
```
