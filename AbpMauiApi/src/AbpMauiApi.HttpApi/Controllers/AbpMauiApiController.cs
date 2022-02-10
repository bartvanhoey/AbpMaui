using AbpMauiApi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpMauiApi.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpMauiApiController : AbpControllerBase
{
    protected AbpMauiApiController()
    {
        LocalizationResource = typeof(AbpMauiApiResource);
    }
}
