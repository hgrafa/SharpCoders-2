using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuitosPraMuitosRelacionamento.Domain.Context;
using MuitosPraMuitosRelacionamento.Domain.Dtos;
using MuitosPraMuitosRelacionamento.Domain.Models;
using MuitosPraMuitosRelacionamento.Infra.Repository;

namespace MuitosPraMuitosRelacionamento.Controllers;

[ApiController]
[Route("matriculas")]
public class MatriculaController : ControllerBase
{
   
  private readonly IMapper _mapper;
  private readonly CursosDbContext _dbContext;

  public MatriculaController(IMapper mapper, CursosDbContext dbContext) {
    _mapper = mapper;
    _dbContext = dbContext;
  }

  [HttpGet]
  public async Task<IActionResult> GetAll(
    [FromQuery(Name = "s")] int size = 5, 
    [FromQuery(Name = "p")] int page = 0
  ) {

    var offset = page * size;

    var alunos = await _dbContext.Alunos.Skip(offset).Take(size).ToListAsync();
    return Ok(alunos);
  }

  [HttpGet("{alunoId}/{cursoId}")]
  public async Task<IActionResult> GetByAlunoECurso(int alunoId, int cursoId) {
    var matricula = _dbContext
      .Matriculas
      .FirstAsync((matricula) => matricula.AlunoId == alunoId && matricula.CursoId == cursoId);

    if(matricula == null)
      return NotFound();

    return Ok(matricula);
  }

  [HttpPost]
  public async Task<IActionResult> Register(MatriculaCreateDto matriculaCreateDto) {
    var matriculaParaCadastrar = _mapper.Map<Matricula>(matriculaCreateDto);

    var entityEntry = await _dbContext.Matriculas.AddAsync(matriculaParaCadastrar);  
    await _dbContext.SaveChangesAsync();

    var matricula = entityEntry.Entity;

    return CreatedAtAction(
      nameof(GetByAlunoECurso), 
      new { alunoId = matricula.AlunoId, cursoId = matricula.CursoId }, 
      matricula
    );
  }

  [HttpPut("{id:int}")]
  public async Task<IActionResult> Update(AlunoUpdateDto alunoUpdateDto, int id) {
    throw new NotImplementedException();
  }

  [HttpDelete("{id:int}")]
  public async Task<IActionResult> Delete(int id) {
    throw new NotImplementedException();
  }

}
