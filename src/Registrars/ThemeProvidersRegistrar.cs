using Microsoft.Extensions.DependencyInjection;
using Soenneker.Quark.Themes.Abstract;

namespace Soenneker.Quark.Themes.Registrars;

public static class ThemeProvidersRegistrar
{
    public static IServiceCollection AddThemeProviderAsScoped(this IServiceCollection services, ThemeProvider themeProvider)
    {
        services.AddScoped<IThemeProvider>(_ => themeProvider);

        return services;
    }
}