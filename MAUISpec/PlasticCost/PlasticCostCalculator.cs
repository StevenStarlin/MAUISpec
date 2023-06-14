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
            // This isn't a clean implementation of this logic,
            // but we'll clean it up before we're done.
            return partWeight * (1 + (_taxRate/100));
        }
    }
}