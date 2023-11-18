using Microsoft.Extensions.DependencyInjection;

namespace Silevis_PSK_23_FoodLoversReborn_Backend.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cf => cf.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection)));

        return services;
    }
}