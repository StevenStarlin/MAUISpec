namespace PlasticCost
{
    public class PlasticCostCalculator
    {
        private Spool _spool;

        public PlasticCostCalculator(Spool spool)
        {
            _spool = spool;
        }

        /// <summary>
        /// Calculate the cost of a part by how much it weighs in grams.
        /// </summary>
        /// <param name="partWeight">Part weight in grams</param>
        /// <returns>Part cost</returns>
        public decimal CalculateByWeight(decimal partWeight)
        {
            return partWeight * _spool.CalculateCostByWeight();
        }

        /// <summary>
        /// Calculate the cost of a part by its length in meters.
        /// </summary>
        /// <param name="partWeight">Part weight in grams</param>
        /// <returns>Part cost</returns>
        public decimal CalculateByLength(decimal partLength)
        {
            return partLength * _spool.CalculateCostByLength();
        }
    }
}