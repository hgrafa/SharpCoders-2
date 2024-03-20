using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuitosPraMuitosRelacionamento.Domain.Context;
using MuitosPraMuitosRelacionamento.Domain.Dtos.Aluno;
using MuitosPraMuitosRelacionamento.Domain.Models;

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

    var alunosResponse = alunos.Select(_mapper.Map<AlunoReadDto>);

    return Ok(alunosResponse);
  }

  [HttpGet("{id:int}")]
  public async Task<IActionResult> GetById(int id) {
    var buscaAluno = await _dbContext.Alunos.FindAsync(id);

    if(buscaAluno == null)
      return NotFound();
    
    var alunosResponse = _mapper.Map<AlunoReadDto>(buscaAluno);

    return Ok(alunosResponse);

  }

  [HttpPost]
  public async Task<IActionResult> Register(AlunoCreateDto alunoCreateDto) {
    var alunoParaCadastrar = _mapper.Map<Aluno>(alunoCreateDto);

    var entityEntry = await _dbContext.Alunos.AddAsync(alunoParaCadastrar);  
    await _dbContext.SaveChangesAsync();

    var alunoSalvo = entityEntry.Entity;
    var alunosResponse = _mapper.Map<AlunoReadDto>(alunoSalvo);

    return CreatedAtAction(nameof(GetById), new { alunoSalvo.Id }, alunosResponse);
  }

  [HttpPut("{id:int}")]
  public async Task<IActionResult> Update(AlunoUpdateDto alunoUpdateDto, int id) {
    var alunoAtualizacoes = _mapper.Map<Aluno>(alunoUpdateDto);

    var alunoParaAtualizar = await _dbContext.Alunos.FindAsync(id);

    if(alunoParaAtualizar is null) 
      return NotFound();

    alunoParaAtualizar.Nome = alunoAtualizacoes.Nome;
    alunoParaAtualizar.Email = alunoAtualizacoes.Email;

    _dbContext.Alunos.Update(alunoParaAtualizar);
    await _dbContext.SaveChangesAsync();

    return Ok("aluno atualizado");
  }

  [HttpDelete("{id:int}")]
  public async Task<IActionResult> Delete(int id) {

    var alunoParaDeletar = _dbContext.Alunos.Find(id);

    if(alunoParaDeletar is null) 
      return NotFound();

    _dbContext.Remove(alunoParaDeletar);
    await _dbContext.SaveChangesAsync();

    return Ok("aluno deletado");
  }

}
