using Volo.Abp.Modularity;

namespace AbpMauiApi;

[DependsOn(
    typeof(AbpMauiApiApplicationModule),
    typeof(AbpMauiApiDomainTestModule)
    )]
public class AbpMauiApiApplicationTestModule : AbpModule
{

}
