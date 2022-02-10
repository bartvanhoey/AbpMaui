using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpMauiApi.Data;

/* This is used if database provider does't define
 * IAbpMauiApiDbSchemaMigrator implementation.
 */
public class NullAbpMauiApiDbSchemaMigrator : IAbpMauiApiDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
