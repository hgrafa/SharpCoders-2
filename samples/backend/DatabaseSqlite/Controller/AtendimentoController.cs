using DatabaseSqlite.Domain;
using DatabaseSqlite.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseSqlite.Controller;

[ApiController]
[Route("atendimentos")]
public class AtendimentoController : ControllerBase
{

  private AppDbContext _appDbContext;

  public AtendimentoController(AppDbContext appDbContext) {
    _appDbContext = appDbContext;
  }

  [HttpGet]
  public IActionResult PegarTodos() {
    var atendimentos = _appDbContext.Atendimentos.ToList();
    return Ok(atendimentos);
  }

  [HttpPost]
  public IActionResult Registrar(Atendimento atendimento) {
    _appDbContext.Atendimentos.Add(atendimento);
    _appDbContext.SaveChanges();

    return Ok("Created!");
  }

}
