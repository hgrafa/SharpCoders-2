using AutoMapper;
using MuitosPraMuitosRelacionamento.Domain.Dtos;
using MuitosPraMuitosRelacionamento.Domain.Models;

namespace MuitosPraMuitosRelacionamento.Domain.Profiles;

public class MatriculaProfile : Profile
{
   
  public MatriculaProfile() {
    CreateMap<MatriculaCreateDto, Matricula>();
   
  }

}