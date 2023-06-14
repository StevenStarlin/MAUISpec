using FluentAssertions;
using PlasticCost;

namespace PlasticCostCalculatorTests.UnitTests
{
    public class PlasticCostCalculatorTests
    {

        [Fact]
        public void Calculator_WhenCalculating_ShouldCalculateACost()
        {
            // Arrange
            var calculator = new PlasticCostCalculator();

            // Act
            var cost = calculator.Calculate(10m);

            // Assert
            cost.Should().Be(10m);
        }
    }
}
