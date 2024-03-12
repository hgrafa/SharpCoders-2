using AutoMapper;
using DatabaseSqlite.Domain.Dtos;
using DatabaseSqlite.Domain.Model;

namespace DatabaseSqlite.Domain.Profiles;

public class FuncionarioProfile : Profile
{
   public FuncionarioProfile() : base() {
      CreateMap<CreateFuncionarioDto, Funcionario>();
   }
}
