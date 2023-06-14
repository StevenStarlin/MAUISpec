namespace PlasticCost
{
    public class PlasticCostCalculatorBuilder
    {
        // I prefer the syntactic cleanliness of builder classes.
        private decimal _taxRate;

        public PlasticCostCalculatorBuilder WithTaxRate(decimal taxRate)
        {
            _taxRate = taxRate;
            return this;
        }

        public PlasticCostCalculator Assemble()
        {
            return new PlasticCostCalculator(_taxRate);
        }
    }
}
