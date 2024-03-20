using System.ComponentModel.DataAnnotations;

namespace MuitosPraMuitosRelacionamento.Domain.Dtos.Aluno;

public class AlunoUpdateDto
{

  public string Nome { get; set; }

  [EmailAddress]
  public string Email { get; set; }

}
