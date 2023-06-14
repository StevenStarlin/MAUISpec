namespace PlasticCost
{
    public class PlasticCostCalculatorBuilder
    {
        private decimal _taxRate;
        private Spool _spool;

        public PlasticCostCalculatorBuilder WithTaxRate(decimal taxRate)
        {
            _taxRate = taxRate;
            return this;
        }

        public PlasticCostCalculatorBuilder WithSpool(Spool spool)
        {
            _spool = spool;
            return this;
        }

        public PlasticCostCalculator Assemble()
        {
            return new PlasticCostCalculator(_taxRate, _spool);
        }
    }
}
