namespace PlasticCost
{
    // All the code in this file is included in all platforms.
    public class PlasticCostCalculator
    {
        /*
         * Dumbest return as possible for spec-driven maturity
         */
        public decimal Calculate(decimal partWeight)
        {
            return 1m * partWeight;
        }
    }
}