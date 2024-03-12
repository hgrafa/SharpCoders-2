using AutoMapper;
using DatabaseSqlite.Domain;
using DatabaseSqlite.Domain.Dtos;
using DatabaseSqlite.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseSqlite.Controller;

[ApiController]
[Route("funcionarios")]
public class FuncionarioController : ControllerBase
{
  
  private readonly AppDbContext _appDbContext;
  private readonly IMapper _mapper;

  public FuncionarioController(AppDbContext appDbContext, IMapper mapper) {
    _appDbContext = appDbContext;
    _mapper = mapper;
  }

  [HttpGet]
  public ActionResult<IEnumerable<Funcionario>> PegarTodos() {
    return Ok(_appDbContext.Funcionarios.ToList());
  }

  [HttpGet("{id:int}")]
  public IActionResult PegarPorId(int id) {
    var buscaFuncionario = _appDbContext.Funcionarios.Find(id);

    if(buscaFuncionario == null)
      return NotFound();
    
    return Ok(buscaFuncionario);
  }

  [HttpPost]
  public IActionResult Cadastrar(CreateFuncionarioDto novoFuncionario) {

    var funcionarioParaCadastro = _mapper.Map<Funcionario>(novoFuncionario);

    var result = _appDbContext.Funcionarios.Add(funcionarioParaCadastro);
    _appDbContext.SaveChanges();    
    var funcionarioSalvo = result.Entity;

    // status 201 + corpo vazio + header com redirecionamento
    return CreatedAtAction(nameof(PegarPorId), new { funcionarioSalvo.Id }, funcionarioSalvo);
  }

}