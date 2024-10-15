using Microsoft.Extensions.DependencyInjection;

namespace VinisLab.EnvironmentVariables.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection InjectEnvironmentVariablesAbstraction(this IServiceCollection services)
    {
        services.AddSingleton<IEnviromentVariables, EnvironmentVariables>();

        return services;
    }
}
