using AutoMapper;
using MuitosPraMuitosRelacionamento.Domain.Dtos.Curso;
using MuitosPraMuitosRelacionamento.Domain.Models;

namespace MuitosPraMuitosRelacionamento.Domain.Profiles;

public class CursoProfile : Profile
{

  public CursoProfile() {
    CreateMap<CursoCreateDto, Curso>();
  }
   
}
