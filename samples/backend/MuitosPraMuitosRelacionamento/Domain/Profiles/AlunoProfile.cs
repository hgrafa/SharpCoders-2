using AutoMapper;
using MuitosPraMuitosRelacionamento.Domain.Dtos;
using MuitosPraMuitosRelacionamento.Domain.Models;

namespace NamespaceName;

public class AlunoProfile : Profile
{

  public AlunoProfile() {
    CreateMap<AlunoCreateDto, Aluno>();
  }
   
}
