namespace PlasticCost
{
    public class PlasticCostCalculator
    {
        private Spool _spool;

        public PlasticCostCalculator(Spool spool)
        {
            _spool = spool;
        }

        public decimal CalculateByWeight(decimal partWeight)
        {
            return partWeight * _spool.CalculateCostByWeight();
        }

        public decimal CalculateByLength(decimal partLength)
        {
            return partLength * _spool.CalculateCostByLength();
        }
    }
}