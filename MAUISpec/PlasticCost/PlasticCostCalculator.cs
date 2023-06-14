namespace PlasticCost
{
    public class PlasticCostCalculator
    {
        private decimal _taxRate;
        private Spool _spool;

        public PlasticCostCalculator(decimal taxRate, Spool spool)
        {
            _taxRate = taxRate;
            _spool = spool;
        }

        public decimal Calculate(decimal partWeight)
        {
            return partWeight * _spool.Calculate();
        }
    }
}