using FluentAssertions;
using PlasticCost;

namespace PlasticCostCalculatorTests
{
    public class PlasticCalculatorSpecTest
    {
        SpoolBuilder? _spoolBuilder;
        PlasticCostCalculator? _calculator;

        public PlasticCalculatorSpecTest()
        {
            _spoolBuilder = new SpoolBuilder()
                .WithSpoolWeight(1000m)
                .WithSpoolCost(20m)
                .WithTaxRate(6m);
        }

        [Fact]
        public void CalculatePlasticCostByWeightSpec()
        {
            // Arrange
            var spool = _spoolBuilder?
                .Assemble();

            var calculator = new PlasticCostCalculatorBuilder()
                .WithSpool(spool!)
                .Assemble();

            // Act
            var spoolCost = spool?.CalculateCostByWeight();
            var cost = calculator?.CalculateByWeight(10m);

            // Assert
            cost.Should().Be(0.212m);
            spoolCost.Should().Be(0.0212m);
        }

        /*
            Approximate volume and filament length information:
            PLA
            Density: 1.25 g/cm^3
            Volume: 0.80 cm^3/g or 800 cm^3/kg
            1.75 mm filament length for 1 kg spool: ~ 330 meters / ~ 1080 feet
            3.00 mm filament length for 1 kg spool: ~ 110 meters / ~ 360 feet
            ABS
            Density: 1.04 g/cm^3
            Volume: 0.96 cm^3/g or 960 cm^3/kg
            1.75 mm filament length for 1 kg spool: ~ 400 meters / ~ 1310 feet
            3.00 mm filament length for 1 kg spool: ~ 130 meters / ~ 430 feet
        */

        [Fact]
        public void CalculatePlasticCostByLengthSpec()
        {
            // Arrange
            var spool = _spoolBuilder?
                .WithSpoolLength(400m)
                .Assemble();

            _calculator = new PlasticCostCalculatorBuilder()
                .WithSpool(_spoolBuilder?.Assemble()!)
                .Assemble();

            // Act
            var spoolCostFromLength = spool?.CalculateCostByLength();
            var partCostFromLength = _calculator?.CalculateByLength(30m);

            // Assert
            spoolCostFromLength.Should().Be(0.053m);
            partCostFromLength.Should().Be(1.59m);
        }
    }
}