namespace managerApp.Api.Services.StartupServices;

public static class MapEndpoints
{
    public static WebApplication MapEndpoint(this WebApplication app)
    {
        app.MapControllers();

        return app;
    }
}
