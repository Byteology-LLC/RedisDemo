using RedisDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RedisDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class RedisDemoController : AbpControllerBase
{
    protected RedisDemoController()
    {
        LocalizationResource = typeof(RedisDemoResource);
    }
}
