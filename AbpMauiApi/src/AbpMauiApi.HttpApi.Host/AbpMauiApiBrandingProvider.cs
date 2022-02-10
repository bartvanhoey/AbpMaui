using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpMauiApi;

[Dependency(ReplaceServices = true)]
public class AbpMauiApiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpMauiApi";
}
