namespace PlasticCost
{
    public class PlasticCostCalculatorBuilder
    {
        private Spool _spool;

        public PlasticCostCalculatorBuilder WithSpool(Spool spool)
        {
            _spool = spool;
            return this;
        }

        public PlasticCostCalculator Assemble()
        {
            return new PlasticCostCalculator(_spool);
        }
    }
}
