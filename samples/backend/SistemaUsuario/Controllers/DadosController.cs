using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SistemaUsuario.Controllers;

[ApiController]
[Route("dados")]
[Authorize(AuthenticationSchemes = "Bearer")]
public class DadosController : ControllerBase
{
   
  [HttpGet("{userName}")]
  public async Task<IActionResult> GetDados(string userName) {
    return Ok("consegui acessar os dados");
  }

}
