using System.ComponentModel.DataAnnotations;
using DtosEAutoMapper.Models;

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

   // extension method
   public User ToUser() {
      return new User() {
         Email = Email,
         Username = Username,
         Password = Password
      };
   }

}
