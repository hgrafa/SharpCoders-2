using System.ComponentModel.DataAnnotations;

namespace MuitosPraMuitosRelacionamento.Domain.Dtos;

public class AlunoCreateDto
{
  [Required]
  public string Nome { get; set; }

  [Required]
  [EmailAddress]
  public string Email { get; set; }

}
