using FluentAssertions;
using PlasticCost;

namespace PlasticCostCalculatorTests
{
    public class PlasticCalculatorSpecTest
    {
        [Fact]
        public void CalculatePlasticCostSpec()
        {
            // Arrange
            var spool = new SpoolBuilder()
                .WithSpoolWeight(1000m)
                .WithSpoolCost(20m)
                .WithTaxRate(6m)
                .Assemble();

            var calculator = new PlasticCostCalculatorBuilder()
                .WithSpool(spool)
                .Assemble();

            // Act
            var spoolCost = spool.Calculate();
            var cost = calculator.Calculate(10m);

            // Assert
            cost.Should().Be(0.212m);
            spoolCost.Should().Be(0.0212m);
        }
    }
}