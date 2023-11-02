using HireWise.Application.Abstractions.Configurations;
using HireWise.Application.Abstractions.Storage;
using HireWise.Application.Abstractions.Token;
using HireWise.Infrastructure.Enums;
using HireWise.Infrastructure.Services.Configurations;
using HireWise.Infrastructure.Services.Storage;
using HireWise.Infrastructure.Services.Storage.Local;
using HireWise.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace HireWise.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
            serviceCollection.AddScoped<IApplicationService, ApplicationService>();
        }

        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : class, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    break;
                case StorageType.AWS:
                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
