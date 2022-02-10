using Volo.Abp.Settings;

namespace AbpMauiApi.Settings;

public class AbpMauiApiSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpMauiApiSettings.MySetting1));
    }
}
