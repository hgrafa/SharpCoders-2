using System.ComponentModel.DataAnnotations;

namespace MuitosPraMuitosRelacionamento.Domain.Dtos.Aluno;

public class AlunoCreateDto
{
  [Required]
  public string Nome { get; set; }

  [Required]
  [EmailAddress]
  public string Email { get; set; }

}
