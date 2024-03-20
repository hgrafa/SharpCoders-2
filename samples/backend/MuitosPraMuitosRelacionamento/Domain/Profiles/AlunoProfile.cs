using AutoMapper;
using MuitosPraMuitosRelacionamento.Domain.Dtos.Aluno;
using MuitosPraMuitosRelacionamento.Domain.Models;

namespace NamespaceName;

public class AlunoProfile : Profile
{

  public AlunoProfile() {
    CreateMap<AlunoCreateDto, Aluno>();
    CreateMap<AlunoUpdateDto, Aluno>();
    CreateMap<Aluno, AlunoReadDto>()
      .AfterMap((aluno, alunoDto) => {
        alunoDto.MatriculasUrl = $"http://localhost:5004/matriculas/aluno/{aluno.Id}";
      });
  }
   
}
