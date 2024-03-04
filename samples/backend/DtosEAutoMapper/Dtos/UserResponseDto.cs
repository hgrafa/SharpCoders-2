using DtosEAutoMapper.Models;

namespace DtosEAutoMapper.Dtos;

public class UserResponseDto
{
   public int Id { get; set; }
   public string? Email { get; set; }
   public string? Username { get; set; }

}
