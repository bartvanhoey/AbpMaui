using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpMauiApi.Blazor;

[Dependency(ReplaceServices = true)]
public class AbpMauiApiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpMauiApi";
}
