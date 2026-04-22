using Soenneker.Mistral.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Mistral.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class MistralOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IMistralOpenApiHttpClient _httpclient;

    public MistralOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IMistralOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
