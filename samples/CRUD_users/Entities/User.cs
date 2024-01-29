namespace CRUD_users.Entities;

public class User
{
   public int Id { get; set; }
   public string Email { get; set; } = null!;
   public string Username { get; set; }
   public string? Nickname {get; set;} = null;
   public string Password { get; set; }

   // 1,hugo@gmail.com,hgrafa,hgrafa,123

   public override string ToString() {
    return $"Id: {Id}\n" 
      + $"Username: {Username}\n"
      + $"Email: {Email}\n"
      + $"Nickname: {Nickname}\n" 
      + $"Password: {Password}";
   }

}