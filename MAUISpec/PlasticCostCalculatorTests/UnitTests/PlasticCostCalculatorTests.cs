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
            var cost = calculator.Calculate();

            // Assert
            cost.Should().Be(1m);
        }
    }
}
