using RedisDemo.MongoDB;
using Volo.Abp.Modularity;

namespace RedisDemo;

[DependsOn(
    typeof(RedisDemoMongoDbTestModule)
    )]
public class RedisDemoDomainTestModule : AbpModule
{

}
