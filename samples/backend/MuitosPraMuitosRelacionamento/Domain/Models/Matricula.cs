namespace MuitosPraMuitosRelacionamento.Domain.Models;

public class Matricula : Entity
{

  public int AlunoId { get; set; }
  public virtual Aluno Aluno { get; set; }

  public int CursoId { get; set; }
  public virtual Curso Curso { get; set; }

}
