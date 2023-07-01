using FluentAssertions;
using PlasticCost.ResinCalculator;

namespace PlasticCostCalculatorTests.UnitTests
{
    public class ResinCostCalculatorTests
    {
        [Fact]
        public void ResinCostCalculator_WhenCalculateCalled_ShouldCalculateResinCostForAPart()
        {
            // Arrange
            var resinBottle = new ResinBottleBuilder()
                .WithPrice(30m)
                .WithVolume(1000m)
                .WithTax(10m)
                .Assemble();

            var resinCostCalculator = new ResinCostCalculatorBuilder()
                .WithBottle(resinBottle)
                .Assemble();

            // Act
            var partCost = resinCostCalculator.Calculate(59m);

            // Assert
            partCost.Should().Be(1.947m);
        }

        [Fact]
        public void ResinCostCalculator_WhenBottleCalculateCalled_ShouldCalculateBottleCostWithTax()
        {
            // Arrange
            var resinBottle = new ResinBottleBuilder()
                .WithPrice(30m)
                .WithVolume(1000m)
                .WithTax(10m)
                .Assemble();

            // Act
            var bottleCostPerGram = resinBottle.Calculate();

            // Assert
            bottleCostPerGram.Should().Be(0.033m);
        }
    }
}
