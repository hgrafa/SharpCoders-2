# Persistencia de dados em APIs

## ORM (Object Relational Mapper)

> Mapeador Objeto Relacional

O C# é regido pela Orientação a Objetos, enquanto que o banco é regido pela paradigma Relacional, a ORM faz a ponte entre essas duas ferramentas.

ORMs populares em C#:

- dapper
- entity framework (EF)

### Migration

> Faz versionamento do seu banco de dados

Um codigo SQL ou similar que ira registrar as mudanças que devem ocorrer no banco e quais seriam as mudanças necessárias para reverter os impactos banco.

## Entity Framework

pacotes a serem instalados:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools

- **driver:** Microsoft.EntityFrameworkCore.Sqlite

### DbContext

- Facilita configuracao do banco na aplicacao
- Permite indicar tabelas e especificidades a serem impactadas somente no banco

### DbSet

- Simboliza as tabelas no banco de dados

```cs
public class AppDbContext : DbContext {

  public DbSet<User> Users {get; set;}

  public AppDbContext(DbContextOptions<AppDbContext> options) 
  : base(options) {

  }

}
```
