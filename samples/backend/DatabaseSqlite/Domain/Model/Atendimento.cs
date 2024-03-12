using System.ComponentModel.DataAnnotations;

namespace DatabaseSqlite.Domain.Model;

public class Atendimento : Entity
{
   [Required]
   public string Nome { get; set; } = null!; 

   public string Relato { get; set; } = string.Empty;

   public bool EstaResolvido { get; set; }
   public bool DesejaRetorno { get; set; }
   public bool EstaAtivo { get; set; } = true;

   public DateTime? CriadoEm { get; set; } = DateTime.Now;
   public DateTime? AtualizadoEm { get; set; } = DateTime.Now;
   public DateTime? DeletadoEm { get; set; } = null;

   // 1:1 - foreign key - chave estrangeira
   public int? EnderecoId { get; set; }
   public virtual Endereco Endereco { get; set; }

   // 1:n - foreign key - chave estrangeira
   public int? FuncionarioId { get; set; }
   public virtual Funcionario Funcionario { get; set; }
   
}
