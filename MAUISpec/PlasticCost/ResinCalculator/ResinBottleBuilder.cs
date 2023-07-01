namespace PlasticCost.ResinCalculator
{
    public class ResinBottleBuilder
    {
        private decimal _price;
        private decimal _volume;
        private decimal _taxRate;

        public ResinBottleBuilder WithTax(decimal taxRate)
        {
            _taxRate = taxRate;
            return this;
        }

        public ResinBottleBuilder WithVolume(decimal volume)
        {
            _volume = volume;
            return this;
        }

        public ResinBottleBuilder WithPrice(decimal price)
        {
            _price = price;
            return this;
        }

        public ResinBottle Assemble()
        {
            return new ResinBottle(_price, _volume, _taxRate);
        }
    }
}
