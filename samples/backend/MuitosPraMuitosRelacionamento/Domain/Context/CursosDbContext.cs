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
// {
//     "id": 5,
//     "nome": "js",
//     "descricao": "aprenda js",
//     "alunos": "http://localhost:5700/alunos?cursoId=5"
// }
