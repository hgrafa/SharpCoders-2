using Composition.Enums;

namespace Composition.Models;

public class User
{
   public string Email { get; set; }
   public string Password { get; set; }
   public Level Level { get; set; }
   public Address Address { get; set; }
   public List<Post> Posts { get; set; } = new List<Post>();
}