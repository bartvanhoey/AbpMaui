using AbpMauiApi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpMauiApi.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpMauiApiEntityFrameworkCoreModule),
    typeof(AbpMauiApiApplicationContractsModule)
    )]
public class AbpMauiApiDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
