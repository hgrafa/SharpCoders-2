using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using SistemaUsuario.Domain.Model;

namespace SistemaUsuario.Infra.Services;

public class TokenService
{

  private IConfiguration _configuration;

    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateToken(User user) {

      Claim[] claims = new Claim[] {
        new("username", user.UserName),
        new("id", user.Id),
        new("loginTimeStamp", DateTime.UtcNow.ToString()),
      };

      var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("efd1290u12u2109u2hno120j01m12hef"));

      var loginCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

      var token = new JwtSecurityToken(
        expires: DateTime.Now.AddMinutes(1),
        signingCredentials: loginCredentials,
        claims: claims
      );

      return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
