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
                .Assemble();

            // Act
            var cost = calculator.Calculate(10m);

            // Assert
            cost.Should().Be(10m);
        }

        [Fact]
        public void Calculator_WhenCalculatingSpoolCost_ShouldConsiderWeightAndCost()
        {
            // Arrange
            var spool = new SpoolBuilder()
                .WithSpoolWeight(1000m)
                .WithSpoolCost(20m)
                .WithTaxRate(6m)
                .Assemble();

            // Act
            var spoolCost = spool.Calculate();

            // Assert
            spoolCost.Should().Be(0.0212m);
        }
    }
}
