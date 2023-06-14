namespace PlasticCost
{
    public class Spool
    {
        private decimal _spoolWeight;
        private decimal _spoolCost;
        private decimal _taxRate;

        public Spool(decimal spoolWeight, decimal spoolCost, decimal taxRate)
        {
            _spoolWeight = spoolWeight;
            _spoolCost = spoolCost;
            _taxRate = taxRate;
        }

        /// <summary>
        /// Spool cost * Positive Tax rate / Spool weight in grams
        /// </summary>
        /// <returns>Cost per gram of filament material</returns>
        public decimal Calculate()
        {
            var decimalTaxRate = 1 + _taxRate / 100;
            return _spoolCost * decimalTaxRate / _spoolWeight;
        }
    }
}