using ContactBook.Api.Services;
using ContactBook.Shared.Handlers.Services;

namespace ContactBook.Api;

public static class ServiceCollectionextensions
{
    public static void AddServicesHandlers(this IServiceCollection services)
    {
        services.AddScoped<IContactService, ContactService>();
    }
}
