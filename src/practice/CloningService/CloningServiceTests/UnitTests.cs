using Xunit;
using Xunit.Abstractions;
using CloningService;

namespace CloningService.UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void ValueType_Clone_Succeeds()
        {
            // Arrange
            var service = new CloningService();
            int source = 1;

            // Act
            var result = service.Clone(source);

            // Assert
            Assert.Equal(source, result);
        }
    }
}