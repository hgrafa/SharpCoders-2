using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaUsuario.Domain.Model;

namespace SistemaUsuario.Domain;

public class UsersDbContext : IdentityDbContext<User>
{
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }
}
