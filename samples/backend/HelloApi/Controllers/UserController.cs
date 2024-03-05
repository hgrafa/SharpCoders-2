using IntrumentosMusicais.Domain.DTO;
using IntrumentosMusicais.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace IntrumentosMusicais.Controllers;

[ApiController] // escutar pedidos
[Route("users")] // mapeando os endpoints(item do pedido)
public class UserController : ControllerBase
{
  
  // pedido = Metodo HTTP + Rota
  // pegar todas = GET /users
  // pegar uma pessoa = GET /users/1

  public static List<User> users = new() {
    new() {
      Id = 1,
      Name = "Pedro",
      Email = "pedro@gmail.com",
      Password = "pedro123"
    },
    new() {
      Id = 2,
      Name = "Martha",
      Email = "martha@gmail.com",
      Password = "martha123"
    }
  };


  [HttpGet]
  public IActionResult GetUsers() {

    var userProfiles = users.Select(user => new UserProfileDto() {
      Id = user.Id,
      Name = user.Name,
      Email = user.Email
    });

    return Ok(userProfiles);
  }

  [HttpGet("{id}")]
  [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserProfileDto))]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public IActionResult GetUserById(int id) {
    User? user = users.Find((user) => user.Id == id);

    if(user == null)
      return NotFound();
    
    UserProfileDto userProfile = new() {
      Id = user.Id,
      Name = user.Name,
      Email = user.Email
    };

    return Ok(userProfile);
  }

  [HttpPost("register")]
  public IActionResult Register(User user) {
    users.Add(user);

    return Ok("user created!");
  }

  [HttpPost("login")]
  public IActionResult Login(User user) {
    users.Add(user);

    return Ok("user created!");
  }

}