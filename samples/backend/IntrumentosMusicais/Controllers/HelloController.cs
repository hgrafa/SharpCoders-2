using IntrumentosMusicais.Model;
using Microsoft.AspNetCore.Mvc;

namespace IntrumentosMusicais.Controllers;

[ApiController]
[Route("api/hello")]
public class HelloController : ControllerBase
{
  
  [HttpGet]
  public string HelloWorld() {
    return "Hello World!";
  }

  [HttpGet("person")] // GET /api/hello/person
  public Person GetPerson() {
    Person p = new() {
      Name = "Joao",
      Age = 25,
      Height = 1.8
    };

    return p;
  }

  [HttpPost]
  public string SayHello(Person person) {
    return $"Hello, {person.Name}";
  }

}
