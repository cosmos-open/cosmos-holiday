using Cosmos.Business.Extensions.Holiday.Globalization.Internals;
using Shouldly;
using Xunit;

namespace Cosmos.Business.Extensions.Holiday.EmbeddedResTests
{
    public class EmbeddedReadingTests
    {
        [Fact]
        public void Read()
        {
            var date = EmbeddedResourceReader.ReadDateResource();

            date.ShouldNotBeNull();
        }


    }
}