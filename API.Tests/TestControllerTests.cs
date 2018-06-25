using System.Threading.Tasks;
using API.Controllers;
using API.Services;
using Moq;
using Xunit;

namespace API.Tests
{
    public class TestControllerTests
    {
        private readonly Mock<BarService> barServiceMock = new Mock<BarService>(null);
        private readonly Mock<FunctionalService> functionalServiceMock = new Mock<FunctionalService>();
        
        private readonly TestController controller;

        public TestControllerTests()
        {
            controller = new TestController(barServiceMock.Object, functionalServiceMock.Object);
        }

        [Fact]
        public async Task Get_CallsLoadSomeData()
        {
            // Act
            await controller.LoadSomeData();

            // Assert
            barServiceMock.Verify(
                x => x.LoadSomeData(),
            Times.Once);
        }
        
        [Fact]
        public async Task Get_ReturnsLoadedData()
        {
            // Arrange
            string expected = "I am loaded data";

            barServiceMock
                .Setup(x => x.LoadSomeData())
                .ReturnsAsync(expected);
            
            // Act
            string result = await controller.LoadSomeData();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}