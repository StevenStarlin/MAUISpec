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
             * Calculate now exists and our tests are passing, let's mature it.
             */
            var cost = calculator.Calculate();

            // Assert
            cost.Should().Be(1m);
        }
    }
}
