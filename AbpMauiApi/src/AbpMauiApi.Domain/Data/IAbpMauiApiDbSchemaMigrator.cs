using System.Threading.Tasks;

namespace AbpMauiApi.Data;

public interface IAbpMauiApiDbSchemaMigrator
{
    Task MigrateAsync();
}
