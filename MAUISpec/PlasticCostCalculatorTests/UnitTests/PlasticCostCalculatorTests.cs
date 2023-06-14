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
            var spool = new SpoolBuilder()
                .WithSpoolWeight(1000m)
                .Assemble();

            var calculator = new PlasticCostCalculatorBuilder()
                .WithSpool(spool)
                .WithTaxRate(6m)
                .Assemble();

            // Act
            var cost = calculator.Calculate(10m);

            // Assert
            cost.Should().Be(10.6m);
        }

        [Fact]
        public void Calculator_WhenCalculatingSpoolCost_ShouldConsiderWeightAndCost()
        {
            // Arrange
            var spool = new SpoolBuilder()
                .WithSpoolWeight(1000m)
                .WithSpoolCost(20m)
                .Assemble();

            // Act
            var spoolCost = spool.Calculate();

            // Assert
            spoolCost.Should().Be(0.02m);
        }
    }
}
