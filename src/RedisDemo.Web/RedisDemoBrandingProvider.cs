using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RedisDemo.Web;

[Dependency(ReplaceServices = true)]
public class RedisDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RedisDemo";
}
