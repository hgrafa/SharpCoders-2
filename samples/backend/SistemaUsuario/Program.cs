using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

builder.Services.AddServicesLayer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();