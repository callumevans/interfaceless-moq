using System.Threading.Tasks;
using API.Services;
using Moq;
using Xunit;

namespace API.Tests
{
    public class BarServiceTests
    {        
        private readonly Mock<FooService> fooServiceMock;
        private readonly BarService service;

        public BarServiceTests()
        {
            fooServiceMock = new Mock<FooService>();
            service = new BarService(fooServiceMock.Object);
        }
        
        [Fact]
        public async Task LoadData()
        {
            await service.LoadSomeData();
            
            fooServiceMock.Verify(
                x => x.AsyncIo(), 
            Times.Once);
        }

        [Fact]
        public async Task LoadData_ReturnsFakeData()
        {
            // Arrange
            string expected = "I am a mocked out test result!";

            fooServiceMock
                .Setup(x => x.AsyncIo())
                .ReturnsAsync(expected);
            
            // Act
            string result = await service.LoadSomeData();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}