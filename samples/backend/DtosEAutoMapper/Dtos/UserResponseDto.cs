using DtosEAutoMapper.Models;

namespace DtosEAutoMapper.Dtos;

public class UserResponseDto
{
   public int Id { get; set; }
   public string? Email { get; set; }
   public string? Username { get; set; }

   public UserResponseDto() {
   }

   public UserResponseDto(User user) {
      Id = user.Id;
      Username = user.Username;
      Email = user.Email;
   }

}
