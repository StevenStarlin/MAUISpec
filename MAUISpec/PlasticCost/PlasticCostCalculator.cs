namespace PlasticCost
{
    public class PlasticCostCalculator
    {
        // I removed spool from here because I preemptively did it.
        // Still some old habits to break.
        private decimal _taxRate;

        public PlasticCostCalculator(decimal taxRate)
        {
            _taxRate = taxRate;
        }

        public decimal Calculate(decimal partWeight)
        {
            // This isn't a clean implementation of this logic,
            // but we'll clean it up before we're done.
            return partWeight;
        }
    }
}