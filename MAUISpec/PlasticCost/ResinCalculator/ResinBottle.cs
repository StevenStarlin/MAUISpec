namespace PlasticCost.ResinCalculator
{
    public class ResinBottle
    {
        private decimal _price;
        private decimal _volume;
        private decimal _taxRate;

        public ResinBottle(decimal price, decimal volume, decimal taxRate)
        {
            _price = price;
            _volume = volume;
            _taxRate = taxRate;
        }

        public decimal Calculate()
        {
            return _price / _volume * GetPositiveTaxRate();
        }

        private decimal GetPositiveTaxRate()
        {
            return 1 + (_taxRate / 100);
        }
    }
}