using System.ComponentModel.DataAnnotations;

namespace DtosEAutoMapper.Dtos;

public class UserRequestDto
{
   [Required]
   [EmailAddress]
   public string? Email { get; set; }

   [Required]
   public string? Username { get; set; }

   [Required]
   [MinLength(8)]
   public string? Password { get; set; }

}
