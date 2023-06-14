namespace PlasticCost
{
    public class PlasticCostCalculator
    {
        private decimal _taxRate;

        public PlasticCostCalculator(decimal taxRate)
        {
            _taxRate = taxRate;
        }

        public decimal Calculate(decimal partWeight)
        {
            // This isn't a clean implementation of this logic,
            // but we'll clean it up before we're done.
            return partWeight * (1 + (_taxRate/100));
        }
    }
}