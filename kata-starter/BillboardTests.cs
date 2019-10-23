using FluentAssertions;
using Kata.Starter.Fixtures;
using Xunit;

namespace Kata.Starter
{
    public class BillboardTests
    {
        [Fact]
        public void Constructor_Returns_Non_Null_Instance()
        {
            var sut = new Billboard("");

            sut.Should().NotBeNull();
            sut.Message.Should().BeEmpty();
        }

        [Theory, AutoDomainData]
        public void Constructor_Assigns_Fields_Using_Supplied_Value(string message)
        {
            var sut = new Billboard(message);

            sut.Message.Should().Be(message);
        }
    }
}
