
using DtosEAutoMapper.Domain.Models;

namespace DtosEAutoMapper.Domain.Dtos;

public class UserResponseDto
{
   public int Id { get; set; }
   public string? Email { get; set; }
   public string? Username { get; set; }
   public bool IsActive { get; set; }

}
