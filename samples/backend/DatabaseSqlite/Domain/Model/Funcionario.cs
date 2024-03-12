namespace DatabaseSqlite.Domain.Model;

public class Funcionario : Entity
{
   public string Nome { get; set; }

   // 1:n - foreign key - chave estrangeira
   public List<Atendimento> Atendimentos { get; set; } = new();
}
