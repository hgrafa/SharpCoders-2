using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NamespaceName;
using SistemaUsuario.Domain.Dto;
using SistemaUsuario.Domain.Model;

namespace SistemaUsuario.Infra.Services;

public class UserService
{ 
   
   private readonly UserManager<User> _userManager;
   private readonly SignInManager<User> _signInManager;
   private readonly IMapper _mapper;
   private readonly TokenService _tokenService;

    public UserService(UserManager<User> userManager, IMapper mapper, SignInManager<User> signInManager, TokenService tokenService)
    {
        _userManager = userManager;
        _mapper = mapper;
        _signInManager = signInManager;
        _tokenService = tokenService;
    }

    public async Task<UserTokenResponseDto> Login(UserLoginDto userLoginDto) {
      var signInResult = await _signInManager.PasswordSignInAsync(userLoginDto.UserName, userLoginDto.Password, false,  false);

      if(!signInResult.Succeeded) {
         throw new Exception("falha ao logar no usuario");
      }

      var user = await _userManager.Users.FirstAsync(user => user.NormalizedUserName!.Equals(userLoginDto.UserName.ToUpper()));

      return new UserTokenResponseDto() {
         Token = _tokenService.GenerateToken(user)
      };
    }

    public async Task Register(UserCreateDto userCreateDto) {
    var user = _mapper.Map<User>(userCreateDto);

      var result = await _userManager.CreateAsync(user, userCreateDto.Password);

      if(!result.Succeeded) 
         throw new Exception("falha ao cadastrar usuario");

   }

}
