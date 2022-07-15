using Volo.Abp.Settings;

namespace RedisDemo.Settings;

public class RedisDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(RedisDemoSettings.MySetting1));
    }
}
