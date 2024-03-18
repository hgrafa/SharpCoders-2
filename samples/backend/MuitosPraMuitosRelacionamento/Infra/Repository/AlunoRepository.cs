using Microsoft.EntityFrameworkCore;
using MuitosPraMuitosRelacionamento.Domain.Models;

namespace MuitosPraMuitosRelacionamento.Infra.Repository;

public class AlunoRepository : IAlunoRepository
{

    private readonly DbContext _dbContext;

    public AlunoRepository(DbContext dbContext) {
      _dbContext = dbContext;
    }

    public async Task<bool> DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Aluno>> FindAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Aluno?> FindById(int ID)
    {
        throw new NotImplementedException();
    }

    public async Task Save(Aluno entity)
    {
        throw new NotImplementedException();
    }

    public async Task<Aluno> Update(int id, Aluno newEntity)
    {
        throw new NotImplementedException();
    }
}
