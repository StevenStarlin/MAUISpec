namespace PlasticCost
{
    public class SpoolBuilder
    {
        private decimal _spoolWeight;
        private decimal _spoolCost;
        private decimal _taxRate;
        private decimal _spoolLength;

        public SpoolBuilder WithSpoolWeight(decimal spoolWeight)
        {
            _spoolWeight = spoolWeight;
            return this;
        }

        public SpoolBuilder WithSpoolCost(decimal spoolCost)
        {
            _spoolCost = spoolCost;
            return this;
        }

        public SpoolBuilder WithTaxRate(decimal taxRate)
        {
            _taxRate = taxRate;
            return this;
        }

        public SpoolBuilder WithSpoolLength(decimal spoolLength)
        {
            _spoolLength = spoolLength;
            return this;
        }

        public Spool Assemble()
        {
            return new Spool(_spoolWeight, _spoolCost, _taxRate, _spoolLength);
        }
    }
}
