using API.Services;
using Xunit;

namespace API.Tests
{
    public class FunctionalServiceTests
    {
        private readonly FunctionalService service = new FunctionalService();

        [Theory]
        [InlineData(10, 11, 21)]
        [InlineData(-5, 5, 0)]
        [InlineData(1, 2, 3)]
        public void Add(int a, int b, int expected)
        {
            // Act
            int result = service.AddSomeNumbers(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}