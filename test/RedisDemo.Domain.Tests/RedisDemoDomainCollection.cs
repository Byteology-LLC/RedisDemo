using RedisDemo.MongoDB;
using Xunit;

namespace RedisDemo;

[CollectionDefinition(RedisDemoTestConsts.CollectionDefinitionName)]
public class RedisDemoDomainCollection : RedisDemoMongoDbCollectionFixtureBase
{

}
