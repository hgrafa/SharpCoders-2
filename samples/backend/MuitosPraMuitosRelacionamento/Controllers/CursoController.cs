using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuitosPraMuitosRelacionamento.Domain.Context;
using MuitosPraMuitosRelacionamento.Domain.Dtos.Curso;
using MuitosPraMuitosRelacionamento.Domain.Models;

namespace MuitosPraMuitosRelacionamento.Controllers;

[ApiController]
[Route("cursos")]
public class CursoController : ControllerBase
{
   
  private readonly IMapper _mapper;
  private readonly CursosDbContext _dbContext;

  public CursoController(IMapper mapper, CursosDbContext dbContext) {
    _mapper = mapper;
    _dbContext = dbContext;
  }

  [HttpGet]
  public async Task<IActionResult> GetAll(
    [FromQuery(Name = "s")] int size = 5, 
    [FromQuery(Name = "p")] int page = 0
  ) {

    var offset = page * size;

    var cursos = await _dbContext.Cursos.Skip(offset).Take(size).ToListAsync();
    return Ok(cursos);
  }

  [HttpGet("{id:int}")]
  public async Task<IActionResult> GetById(int id) {
    var buscaCurso = await _dbContext.Cursos.FindAsync(id);

    if(buscaCurso == null)
      return NotFound();
    
    return Ok(buscaCurso);

  }

  [HttpPost]
  public async Task<IActionResult> Register(CursoCreateDto cursoCreateDto) {
    var cursoParaCadastrar = _mapper.Map<Curso>(cursoCreateDto);

    var entityEntry = await _dbContext.Cursos.AddAsync(cursoParaCadastrar);  
    await _dbContext.SaveChangesAsync();

    var cursoSalvo = entityEntry.Entity;

    return CreatedAtAction(nameof(GetById), new { cursoSalvo.Id }, cursoSalvo);
  }

  [HttpPut("{id:int}")]
  public async Task<IActionResult> Update(CursoUpdateDto cursoUpdateDto, int id) {
    var cursoAtualizacoes = _mapper.Map<Curso>(cursoUpdateDto);

    var cursoParaAtualizar = await _dbContext.Cursos.FindAsync(id);

    if(cursoParaAtualizar is null) 
      return NotFound();

    cursoParaAtualizar.Nome = cursoAtualizacoes.Nome;

    _dbContext.Cursos.Update(cursoParaAtualizar);
    await _dbContext.SaveChangesAsync();

    return Ok("curso atualizado");
  }

  [HttpDelete("{id:int}")]
  public async Task<IActionResult> Delete(int id) {

    var cursoParaDeletar = _dbContext.Cursos.Find(id);

    if(cursoParaDeletar is null) 
      return NotFound();

    _dbContext.Remove(cursoParaDeletar);
    await _dbContext.SaveChangesAsync();

    return Ok("curso deletado");
  }
}
