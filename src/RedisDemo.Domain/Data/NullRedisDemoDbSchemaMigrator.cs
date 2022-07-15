using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RedisDemo.Data;

/* This is used if database provider does't define
 * IRedisDemoDbSchemaMigrator implementation.
 */
public class NullRedisDemoDbSchemaMigrator : IRedisDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
