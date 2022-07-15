using RedisDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace RedisDemo.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class RedisDemoPageModel : AbpPageModel
{
    protected RedisDemoPageModel()
    {
        LocalizationResourceType = typeof(RedisDemoResource);
    }
}
