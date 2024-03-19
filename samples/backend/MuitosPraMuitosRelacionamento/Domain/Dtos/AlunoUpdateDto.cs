using System.ComponentModel.DataAnnotations;

namespace MuitosPraMuitosRelacionamento.Domain.Dtos;

public class AlunoUpdateDto
{

  public string Nome { get; set; }

  [EmailAddress]
  public string Email { get; set; }

}
