using AbpMauiApi.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpMauiApi.Permissions;

public class AbpMauiApiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpMauiApiPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpMauiApiPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpMauiApiResource>(name);
    }
}
