using AbpMauiApi.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpMauiApi;

[DependsOn(
    typeof(AbpMauiApiEntityFrameworkCoreTestModule)
    )]
public class AbpMauiApiDomainTestModule : AbpModule
{

}
