namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.Extensions;

public static class CorsSetup
{
    public static IServiceCollection SetupCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("_localorigin", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
            });
        });

        return services;
    }
}