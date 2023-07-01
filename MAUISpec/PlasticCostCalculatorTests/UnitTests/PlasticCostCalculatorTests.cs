using FluentAssertions;
using PlasticCost.FilamentCalculator;

namespace PlasticCostCalculatorTests.UnitTests
{
    public class PlasticCostCalculatorTests
    {
        SpoolBuilder? _spoolBuilder;
        PlasticCostCalculator? _calculator;

        public PlasticCostCalculatorTests()
        {
            _spoolBuilder = new SpoolBuilder()
                .WithSpoolWeight(1000m)
                .WithSpoolCost(20m)
                .WithTaxRate(6m);
        }

        private void AssembleCalculator()
        {
            var calculatorBuilder = new PlasticCostCalculatorBuilder()
                            .WithSpool(_spoolBuilder?.Assemble()!);

            _calculator = calculatorBuilder.Assemble();
        }

        [Fact]
        public void Calculator_WhenCalculating_ShouldCalculateACost()
        {
            // Arrange
            AssembleCalculator();

            // Act
            var cost = _calculator?.CalculateByWeight(10m);

            // Assert
            cost.Should().Be(0.212m);
        }

        [Fact]
        public void Calculator_WhenCalculatingSpoolCost_ShouldConsiderWeightAndCost()
        {
            // Arrange
            AssembleCalculator();

            // Act
            var spoolCost = _spoolBuilder?
                .Assemble()
                .CalculateCostByWeight();

            // Assert
            spoolCost.Should().Be(0.0212m);
        }

        [Fact]
        public void Calculator_WhenCalculatingPriceFromLength_ShouldCalculateAccurately()
        {
            // Arrange
            _spoolBuilder = _spoolBuilder?
                .WithSpoolLength(400m);

            AssembleCalculator();

            // Act
            var partCost = _calculator?
                .CalculateByLength(30m);

            // Assert
            partCost.Should().Be(1.59m);
        }

        [Fact]
        public void Calculator_WhenCalculatingSpoolCostFromLength_ShouldCalculateAccurately()
        {
            // Arrange
            var spool = _spoolBuilder?
                .WithSpoolLength(400m)
                .Assemble();

            // Act
            var spoolCostByLength = spool?
                .CalculateCostByLength();

            // Assert
            spoolCostByLength.Should().Be(0.053m);
        }
    }
}
