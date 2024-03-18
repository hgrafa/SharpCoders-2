using Microsoft.EntityFrameworkCore;
using MuitosPraMuitosRelacionamento.Domain.Models;

namespace MuitosPraMuitosRelacionamento.Domain.Context;

public class CursosDbContext : DbContext
{

    public CursosDbContext(DbContextOptions<CursosDbContext> options) 
    : base(options){
    }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
}

