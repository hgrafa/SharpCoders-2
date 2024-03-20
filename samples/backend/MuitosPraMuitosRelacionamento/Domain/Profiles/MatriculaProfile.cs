using AutoMapper;
using MuitosPraMuitosRelacionamento.Domain.Dtos;
using MuitosPraMuitosRelacionamento.Domain.Dtos.Matricula;
using MuitosPraMuitosRelacionamento.Domain.Models;

namespace MuitosPraMuitosRelacionamento.Domain.Profiles;

public class MatriculaProfile : Profile
{
  

  public MatriculaProfile() {
    CreateMap<MatriculaCreateDto, Matricula>();
    CreateMap<Aluno, AlunoMatriculaReadDto>();
    CreateMap<Curso, CursoMatriculaReadDto>();
    CreateMap<Matricula, MatriculaReadDto>()
      .ForMember(matriculaDto => matriculaDto.AlunoDto, options => options.MapFrom(matricula => matricula.Aluno))
      .ForMember(matriculaDto => matriculaDto.CursoDto, options => options.MapFrom(matricula => matricula.Curso));
  }

}