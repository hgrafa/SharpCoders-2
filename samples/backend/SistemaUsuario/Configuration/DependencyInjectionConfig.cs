using SistemaUsuario.Infra.Services;

namespace SistemaUsuario.Configuration;

public static class DependencyInjectionConfig
{

  public static IServiceCollection AddRepositoriesLayer(this IServiceCollection services) {

    return services;
  }

  public static IServiceCollection AddServicesLayer(this IServiceCollection services) {

    services.AddScoped<UserService>();

    return services;
  }
   
}
