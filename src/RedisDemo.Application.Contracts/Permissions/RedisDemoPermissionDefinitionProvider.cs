using RedisDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RedisDemo.Permissions;

public class RedisDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(RedisDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(RedisDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<RedisDemoResource>(name);
    }
}
