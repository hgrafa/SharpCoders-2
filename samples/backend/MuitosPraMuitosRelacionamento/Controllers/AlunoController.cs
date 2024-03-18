using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuitosPraMuitosRelacionamento.Domain.Context;
using MuitosPraMuitosRelacionamento.Domain.Dtos;
using MuitosPraMuitosRelacionamento.Domain.Models;
using MuitosPraMuitosRelacionamento.Infra.Repository;

namespace MuitosPraMuitosRelacionamento.Controllers;

[ApiController]
[Route("alunos")]
public class AlunoController : ControllerBase
{
   
  private readonly IMapper _mapper;
  private readonly CursosDbContext _dbContext;

  public AlunoController(IMapper mapper, CursosDbContext dbContext) {
    _mapper = mapper;
    _dbContext = dbContext;
  }

  [HttpGet]
  public async Task<IActionResult> GetAll(
    [FromQuery(Name = "s")] int size = 5, 
    [FromQuery(Name = "p")] int page = 0
  ) {

    // pag. 0: 1 -> 10
    // pag. 1: 11 -> 20
    // pag. 2: 21 -> 30

    var offset = page * size;

    var alunos = await _dbContext.Alunos.Skip(offset).Take(size).ToListAsync();
    return Ok(alunos);
  }

  [HttpGet("{id:int}")]
  public async Task<IActionResult> GetById(int id) {
    var buscaAluno = await _dbContext.Alunos.FindAsync(id);

    if(buscaAluno == null)
      return NotFound();
    
    return Ok(buscaAluno);

  }

  [HttpPost]
  public async Task<IActionResult> Register(AlunoCreateDto alunoCreateDto) {
    var alunoParaCadastrar = _mapper.Map<Aluno>(alunoCreateDto);

    var entityEntry = await _dbContext.Alunos.AddAsync(alunoParaCadastrar);  
    await _dbContext.SaveChangesAsync();

    var alunoSalvo = entityEntry.Entity;

    return CreatedAtAction(nameof(GetById), new { alunoSalvo.Id }, alunoSalvo);
  }

}
