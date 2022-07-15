using RedisDemo.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RedisDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(RedisDemoMongoDbModule),
    typeof(RedisDemoApplicationContractsModule)
    )]
public class RedisDemoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
