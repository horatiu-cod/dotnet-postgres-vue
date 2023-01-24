namespace managerApp.Api.Services.StartupServices;

public static class DependencyInjectionSetup
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers(); 

        return services;
    }
}
