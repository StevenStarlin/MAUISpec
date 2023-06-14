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
            return partWeight;
        }
    }
}