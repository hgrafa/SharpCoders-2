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

  public List<User> users = new() {
    new() {
      Id = 1,
      Name = "Pedro",
      Email = "pedro@gmail.com",
      Age = 30
    },
    new() {
      Id = 2,
      Name = "Martha",
      Email = "martha@gmail.com",
      Age = 25
    }
  };


  [HttpGet]
  public ActionResult<List<User>> GetUsers() {
    return Ok(users);
  }

  [HttpGet("{id}")]
  public ActionResult<User?> GetUserById(int id) {
    User? user = users.Find((user) => user.Id == id);

    return user != null ? Ok(user) : NotFound();
  }

}