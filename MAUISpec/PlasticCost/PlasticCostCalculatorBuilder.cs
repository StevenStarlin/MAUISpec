namespace PlasticCost
{
    public class PlasticCostCalculatorBuilder
    {
        // I prefer the syntactic cleanliness of builder classes.
        private decimal _taxRate;
        private Spool _spool;

        public PlasticCostCalculatorBuilder WithSpool(Spool spool)
        {
            _spool = spool;
            return this;
        }

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
