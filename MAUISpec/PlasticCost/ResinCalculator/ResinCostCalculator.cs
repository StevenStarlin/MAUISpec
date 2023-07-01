namespace PlasticCost.ResinCalculator
{
    public class ResinCostCalculator
    {
        private ResinBottle resinBottle;

        public ResinCostCalculator(ResinBottle resinBottle)
        {
            this.resinBottle = resinBottle;
        }

        public decimal Calculate(decimal partVolume)
        {
            var bottleCostPerGram = resinBottle.Calculate();
            return partVolume * bottleCostPerGram;
        }
    }
}
