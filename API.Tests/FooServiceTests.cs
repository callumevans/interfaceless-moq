using System.Threading.Tasks;
using API.Services;
using Xunit;

namespace API.Tests
{
    public class FooServiceTests
    {
        private readonly FooService service = new FooService();

        [Fact]
        public async Task DoIo_ReturnsAString()
        {
            // Arrange
            string expected = "Let's just pretend I was loaded from a database or something";
            
            // Act
            string result = await service.AsyncIo();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}