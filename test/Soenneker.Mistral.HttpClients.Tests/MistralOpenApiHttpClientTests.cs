using Soenneker.Mistral.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Mistral.HttpClients.Tests;

[Collection("Collection")]
public sealed class MistralOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IMistralOpenApiHttpClient _httpclient;

    public MistralOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IMistralOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
