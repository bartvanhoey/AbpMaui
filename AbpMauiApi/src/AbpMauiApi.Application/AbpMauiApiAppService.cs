using System;
using System.Collections.Generic;
using System.Text;
using AbpMauiApi.Localization;
using Volo.Abp.Application.Services;

namespace AbpMauiApi;

/* Inherit your application services from this class.
 */
public abstract class AbpMauiApiAppService : ApplicationService
{
    protected AbpMauiApiAppService()
    {
        LocalizationResource = typeof(AbpMauiApiResource);
    }
}
