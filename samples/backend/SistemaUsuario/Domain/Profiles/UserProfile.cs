using AutoMapper;
using SistemaUsuario.Domain.Dto;
using SistemaUsuario.Domain.Model;

namespace SistemaUsuario.Domain.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
      CreateMap<UserCreateDto, User>();
    }
}
