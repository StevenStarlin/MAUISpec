namespace PlasticCost
{
    public class Spool
    {
        private decimal _spoolWeight;
        private decimal _spoolCost;

        public Spool(decimal spoolWeight, decimal spoolCost)
        {
            _spoolWeight = spoolWeight;
            _spoolCost = spoolCost;
        }

        public decimal Calculate()
        {
            return _spoolCost / _spoolWeight;
        }
    }
}