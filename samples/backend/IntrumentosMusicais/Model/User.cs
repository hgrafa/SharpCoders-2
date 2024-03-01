using System.ComponentModel.DataAnnotations;

namespace IntrumentosMusicais.Model;

public class User
{
   [Key]
   public int Id { get; set; }
   public string Name { get; set; }
   public string? Password { get; set; }
   public string? Email { get; set; }
   public DateTime? CreatedAt { get; set; } = DateTime.Now;
   public DateTime? UpdatedAt { get; set; } = DateTime.Now;

}
