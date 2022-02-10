using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpMauiApi.Data;
using Volo.Abp.DependencyInjection;

namespace AbpMauiApi.EntityFrameworkCore;

public class EntityFrameworkCoreAbpMauiApiDbSchemaMigrator
    : IAbpMauiApiDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpMauiApiDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpMauiApiDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpMauiApiDbContext>()
            .Database
            .MigrateAsync();
    }
}
