using System.ComponentModel.DataAnnotations;

namespace SistemaUsuario.Domain.Dto;

public class UserCreateDto
{

  [Required]
  [EmailAddress]
  public string Email { get; set; }

  [Required]
  public string UserName { get; set; }

  [Required]
  [DataType(DataType.Password)]
  public string Password { get; set; }

  [Required]
  [Compare("Password")]
  public string PasswordConfirmation { get; set; }

}
