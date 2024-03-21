using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
   public async Task<IActionResult> Login(
      UserLoginDto userLoginDto
   ) {
      return Ok("not implemented");
   }
}
