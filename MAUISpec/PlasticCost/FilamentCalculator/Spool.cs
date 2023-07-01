namespace PlasticCost.FilamentCalculator
{
    public class Spool
    {
        private decimal _spoolWeight;
        private decimal _spoolCost;
        private decimal _taxRate;
        private decimal _spoolLength;

        public Spool(decimal spoolWeight, decimal spoolCost, decimal taxRate, decimal spoolLength)
        {
            _spoolWeight = spoolWeight;
            _spoolCost = spoolCost;
            _taxRate = taxRate;
            _spoolLength = spoolLength;
        }

        /// <summary>
        /// Spool cost * Positive tax rate / Spool weight in grams
        /// </summary>
        /// <returns>Cost per gram of filament material</returns>
        public decimal CalculateCostByWeight()
        {
            return _spoolCost * GetPositiveTaxRate() / _spoolWeight;
        }

        /// <summary>
        /// Spool cost * Positive tax rate / spool length in meters.
        /// </summary>
        /// <returns></returns>
        public decimal CalculateCostByLength()
        {
            // spoolCost * taxRate / spoolLength
            return _spoolCost * GetPositiveTaxRate() / _spoolLength;
        }

        private decimal GetPositiveTaxRate()
        {
            return 1 + _taxRate / 100;
        }
    }
}