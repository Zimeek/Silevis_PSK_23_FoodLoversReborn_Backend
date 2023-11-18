namespace Silevis_PSK_23_FoodLoversReborn_Backend.API.Extensions;
using Silevis_PSK_23_FoodLoversReborn_Backend.Application;

public static class MediatRSetup
{
    public static IServiceCollection SetupMediatR(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddMediatR(options =>
            options.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

        return serviceCollection;
    }
}