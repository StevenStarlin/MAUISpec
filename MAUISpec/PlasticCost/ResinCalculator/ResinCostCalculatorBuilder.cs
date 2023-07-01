namespace PlasticCost.ResinCalculator
{
    public class ResinCostCalculatorBuilder
    {
        private ResinBottle _resinBottle;

        public ResinCostCalculatorBuilder WithBottle(ResinBottle resinBottle)
        {
            _resinBottle = resinBottle;
            return this;
        }

        public ResinCostCalculator Assemble()
        {
            return new ResinCostCalculator(_resinBottle);
        }
    }
}
