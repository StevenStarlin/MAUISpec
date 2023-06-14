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
    }
}
