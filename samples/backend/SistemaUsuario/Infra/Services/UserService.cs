using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SistemaUsuario.Domain.Dto;
using SistemaUsuario.Domain.Model;

namespace SistemaUsuario.Infra.Services;

public class UserService
{ 
   
   private readonly UserManager<User> _userManager;
   private readonly SignInManager<User> _signInManager;
   private readonly IMapper _mapper;

    public UserService(UserManager<User> userManager, IMapper mapper, SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _mapper = mapper;
        _signInManager = signInManager;
    }

    public async Task Register(UserCreateDto userCreateDto) {
    var user = _mapper.Map<User>(userCreateDto);

      var result = await _userManager.CreateAsync(user, userCreateDto.Password);

      if(!result.Succeeded) 
         throw new Exception("falha ao cadastrar usuario");

   }

}
