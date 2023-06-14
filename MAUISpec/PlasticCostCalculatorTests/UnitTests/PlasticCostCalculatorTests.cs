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
            /*
             * We have a nearly identical test because the spec is
             * still immature. The calculate function doesn't exist
             * So let's add it to the PlasticCost project.
             */
            var cost = calculator.Calculate();

            // Assert
            cost.Should().Be(1m);
        }
    }
}
