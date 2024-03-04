using DtosEAutoMapper.Dtos;
using DtosEAutoMapper.Models;
using Microsoft.AspNetCore.Mvc;

namespace DtosEAutoMapper.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{

  private static List<User> users = new () {
    new () {
      Id = 1,
      Username = "User1",
      Email = "user1@example.com",
      Password = "User1"
    },
    new () {
      Id = 2,
      Username = "User2",
      Email = "user2@example.com",
      Password = "User2"
    }
  };

  [HttpGet]
  [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
  public IActionResult GetAll() {

    if(users.Count == 0) {
      return NoContent();
    }

    var usersResponse = users.Select(user => new UserResponseDto {
      Id = user.Id,
      Username = user.Username,
      Email = user.Email
    });

    return Ok(usersResponse);
  }

  [HttpPost]
  public IActionResult Register(UserRequestDto userRequest) {

    bool isEmailAlreadyUsed = users.Any((user) => user.Email == userRequest.Email);

    if(isEmailAlreadyUsed) {
      return BadRequest();
    }

    // 5 elementos => index 0 ao index 4

    User user = new() {
      Id = users.Count + 1,
      Email = userRequest.Email,
      Username = userRequest.Username,
      Password = userRequest.Password
    };

    users.Add(user);
    return Created();
  }

}
