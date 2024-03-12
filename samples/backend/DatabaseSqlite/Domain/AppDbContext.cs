using DatabaseSqlite.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseSqlite.Domain;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
    : base(options){
    }
    
    public DbSet<Atendimento> Atendimentos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
}
