using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace RedisDemo.Pages;

[Collection(RedisDemoTestConsts.CollectionDefinitionName)]
public class Index_Tests : RedisDemoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
