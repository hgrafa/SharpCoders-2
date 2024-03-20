using MuitosPraMuitosRelacionamento.Domain.Dtos.Matricula;

namespace MuitosPraMuitosRelacionamento.Domain.Dtos;

public class MatriculaReadDto
{
   public AlunoMatriculaReadDto AlunoDto {get; set;}
   public CursoMatriculaReadDto CursoDto { get; set; }
}

