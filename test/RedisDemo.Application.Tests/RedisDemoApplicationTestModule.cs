using Volo.Abp.Modularity;

namespace RedisDemo;

[DependsOn(
    typeof(RedisDemoApplicationModule),
    typeof(RedisDemoDomainTestModule)
    )]
public class RedisDemoApplicationTestModule : AbpModule
{

}
