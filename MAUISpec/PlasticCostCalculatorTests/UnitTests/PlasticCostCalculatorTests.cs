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
            var calculator = new PlasticCostCalculatorBuilder()
                .WithTaxRate(6m)
                .Assemble();

            // Act
            var cost = calculator.Calculate(10m);

            // Assert
            cost.Should().Be(10.6m);
        }
    }
}
