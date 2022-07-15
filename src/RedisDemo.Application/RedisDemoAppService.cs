using System;
using System.Collections.Generic;
using System.Text;
using RedisDemo.Localization;
using Volo.Abp.Application.Services;

namespace RedisDemo;

/* Inherit your application services from this class.
 */
public abstract class RedisDemoAppService : ApplicationService
{
    protected RedisDemoAppService()
    {
        LocalizationResource = typeof(RedisDemoResource);
    }
}
