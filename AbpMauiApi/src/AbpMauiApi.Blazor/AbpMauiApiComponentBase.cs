using AbpMauiApi.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpMauiApi.Blazor;

public abstract class AbpMauiApiComponentBase : AbpComponentBase
{
    protected AbpMauiApiComponentBase()
    {
        LocalizationResource = typeof(AbpMauiApiResource);
    }
}
