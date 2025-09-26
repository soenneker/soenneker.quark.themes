using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Themes.Tests;

[Collection("Collection")]
public sealed class ThemeTests : FixturedUnitTest
{
    public ThemeTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
