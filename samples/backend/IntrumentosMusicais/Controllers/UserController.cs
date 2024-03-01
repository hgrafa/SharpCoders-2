using IntrumentosMusicais.Model;
using Microsoft.AspNetCore.Mvc;

namespace IntrumentosMusicais.Controllers;

[ApiController] // escutar pedidos
[Route("/users")] // mapeando os endpoints(item do pedido)
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
    return Ok(users);
  }

  [HttpGet("{id}")]
  [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public IActionResult GetUserById(int id) {
    User? user = users.Find((user) => user.Id == id);

    return user != null ? Ok(user) : NotFound();
  }

  [HttpPost]
  public IActionResult CreateUser(User user) {
    users.Add(user);

    return Ok("user created!");
  }

}