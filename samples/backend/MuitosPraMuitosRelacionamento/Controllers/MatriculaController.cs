using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuitosPraMuitosRelacionamento.Domain.Context;
using MuitosPraMuitosRelacionamento.Domain.Dtos;
using MuitosPraMuitosRelacionamento.Domain.Models;

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

    var matriculas = await _dbContext.Matriculas.Skip(offset).Take(size).ToListAsync();
    
    var matriculasResponse = matriculas.Select(_mapper.Map<MatriculaReadDto>);

    return Ok(matriculasResponse);
  }

  
  [HttpGet("aluno/{alunoId}")]
  public async Task<IActionResult> GetByAlunoECurso(int alunoId) {
    var matriculas = await _dbContext
      .Matriculas
      .Where((matricula) => matricula.AlunoId == alunoId)
      .ToListAsync();

    if(matriculas.Count == 0)
      return NotFound();

    var matriculasResponse = matriculas.Select(_mapper.Map<MatriculaReadDto>);

    return Ok(matriculasResponse);
  }

  [HttpGet("{alunoId:int}/{cursoId:int}")]
  public async Task<IActionResult> GetByAlunoECurso([FromRoute]int alunoId, [FromRoute]int cursoId) {
    var matricula = _dbContext
      .Matriculas
      .FirstAsync((matricula) => matricula.AlunoId == alunoId && matricula.CursoId == cursoId);

    if(matricula == null)
      return NotFound();

    var matriculaResponse = _mapper.Map<MatriculaReadDto>(matricula);


    return Ok(matriculaResponse);
  }

  [HttpPost]
  public async Task<IActionResult> Register(MatriculaCreateDto matriculaCreateDto) {
    var matriculaParaCadastrar = _mapper.Map<Matricula>(matriculaCreateDto);

    var entityEntry = await _dbContext.Matriculas.AddAsync(matriculaParaCadastrar);  
    await _dbContext.SaveChangesAsync();

    var matricula = entityEntry.Entity;
    var matriculaResponse = _mapper.Map<MatriculaReadDto>(matricula);

    return CreatedAtAction(
      nameof(GetByAlunoECurso), 
      new { alunoId = matricula.AlunoId, cursoId = matricula.CursoId }, 
      matriculaResponse
    );
  }

  [HttpPut("{id:int}")]
  public async Task<IActionResult> Update(int id) {
    throw new NotImplementedException();
  }

  [HttpDelete("{id:int}")]
  public async Task<IActionResult> Delete(int id) {
    throw new NotImplementedException();
  }

}

