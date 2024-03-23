using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NamespaceName;
using SistemaUsuario.Domain.Dto;
using SistemaUsuario.Domain.Model;
using SistemaUsuario.Infra.Services;

namespace SistemaUsuario.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{  
   private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

   [HttpPost("register")]
   public async Task<IActionResult> Register(
      UserCreateDto userCreateDto
   ) {
      
      await _userService.Register(userCreateDto);
      return Created();
   }

   [HttpPost("login")]
   [ProducesResponseType(type: typeof(UserTokenResponseDto), statusCode: StatusCodes.Status200OK)]
   public async Task<IActionResult> Login(
      UserLoginDto userLoginDto
   ) {
      var tokenResponse = await _userService.Login(userLoginDto);

      return Ok(tokenResponse);
   }
}
