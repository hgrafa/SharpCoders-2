
using AutoMapper;
using DtosEAutoMapper.Domain.Dtos;
using DtosEAutoMapper.Domain.Models;
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

  private readonly IMapper _mapper;

  public UserController(IMapper mapper) {
    _mapper = mapper;
  }

  [HttpGet]
  [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
  public IActionResult GetAll() {

    if(users.Count == 0) {
      return NoContent();
    }

    var usersResponse = users.Select(_mapper.Map<UserResponseDto>);

    return Ok(usersResponse);
  }

  [HttpPost]
  public IActionResult Register(UserRequestDto userRequest) {

    bool isEmailAlreadyUsed = users.Any((user) => user.Email == userRequest.Email);

    if(isEmailAlreadyUsed) {
      return BadRequest();
    }

    // 5 elementos => index 0 ao index 4

    User user = _mapper.Map<User>(userRequest);
    user.Id = users.Count + 1;

    users.Add(user);
    return Created();
  }

}
