using System.Threading.Tasks;

namespace RedisDemo.Data;

public interface IRedisDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
