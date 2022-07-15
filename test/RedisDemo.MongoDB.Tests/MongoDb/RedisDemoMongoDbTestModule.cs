using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace RedisDemo.MongoDB;

[DependsOn(
    typeof(RedisDemoTestBaseModule),
    typeof(RedisDemoMongoDbModule)
    )]
public class RedisDemoMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var stringArray = RedisDemoMongoDbFixture.ConnectionString.Split('?');
        var connectionString = stringArray[0].EnsureEndsWith('/') +
                                   "Db_" +
                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = connectionString;
        });
    }
}
