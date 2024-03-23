using System.ComponentModel.DataAnnotations;

namespace SistemaUsuario.Domain.Dto;

public class UserLoginDto
{
   
  [Required]
  public string UserName { get; set; }

  [Required]
  public string Password { get; set; }

}
