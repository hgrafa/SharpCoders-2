using AutoMapper;
using DtosEAutoMapper.Domain.Dtos;
using DtosEAutoMapper.Domain.Models;

namespace DtosEAutoMapper.Domain.Profiles;

public class UserProfile : Profile
{

  public UserProfile() {
    CreateMap<User, UserResponseDto>();
    CreateMap<UserRequestDto, User>();
  }
   
}

