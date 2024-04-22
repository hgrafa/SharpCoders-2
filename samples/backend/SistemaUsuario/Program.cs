using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SistemaUsuario.Configuration;
using SistemaUsuario.Domain;
using SistemaUsuario.Domain.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

builder.Services.
    AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var defaultConnectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");
var serverVersion = ServerVersion.AutoDetect(defaultConnectionString);

builder.Services.AddDbContext<UsersDbContext>(options => {
    options.UseMySql(defaultConnectionString, serverVersion);
});

builder.Services
    .AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<UsersDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters() {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("efd1290u12u2109u2hno120j01m12hef")),
        ClockSkew = TimeSpan.Zero,
        ValidateAudience = false,
        ValidateIssuer = false,
    };
});

builder.Services.AddAuthorization(auth => {
    auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
        .RequireAuthenticatedUser()
        .Build());
});

// AuthorizationHandler<IdValido>
// public class IdValido { public IdValido(int id) {}}
// public IdAuthorization : AuthorizationHandler<IdValido> 

// protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdValido requirement)

// builder.Services.AddAuthorization(options => { options.AddPolicy("IdValido")})
// builder.Services.AddSigleton<IAuthorizationHandler, IdAuthorization>();
builder.Services.AddServicesLayer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();