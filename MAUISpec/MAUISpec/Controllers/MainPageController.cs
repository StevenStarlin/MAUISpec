using PlasticCost;
using System.ComponentModel;
using System.Globalization;

namespace MAUISpec.Controllers
{
    /* INotifyPropertyChanged could be extracted 
     * to a base controller class, but for now,
     * this is all we need.
     */
    internal class MainPageController : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region [Private Fields]
        private CultureInfo _cultureInfo => CultureInfo.CreateSpecificCulture("en-US");
        private PlasticCostCalculator _plasticCostCalculator;
        private string _partWeight;
        private string _partLength = "";
        private string _spoolLength = "400";
        private string _spoolWeight = "1000";
        private string _spoolCost = "22.99";
        private string _taxRate = "6";
        private string _partCost = "0.00";
        private bool _calculatePriceByWeight = false;
        private bool _hideCalculateByLength = true;
        #endregion

        #region [Public Properties]
        public string PartWeight
        {
            get => _partWeight;
            set
            {
                _partWeight = value;
                Broadcast(nameof(PartWeight));
            }
        }

        public string PartLength
        {
            get => _partLength;
            set
            {
                _partLength = value;
                Broadcast(nameof(PartLength));
            }
        }

        public string SpoolLength
        {
            get => _spoolLength;
            set
            {
                _spoolLength = value;
                Broadcast(nameof(SpoolLength));
            }
        }

        public string SpoolWeight
        {
            get => _spoolWeight;
            set
            {
                _spoolWeight = value;
                Broadcast(nameof(SpoolWeight));
            }
        }

        public string SpoolCost
        {
            get => _spoolCost;
            set
            {
                _spoolCost = value;
                Broadcast(nameof(SpoolCost));
            }
        }

        public string TaxRate
        {
            get => _taxRate;
            set
            {
                _taxRate = value;
                Broadcast(nameof(TaxRate));
            }
        }

        public string PartCost
        {
            get => _partCost;
            set
            {
                _partCost = value;
                Broadcast(nameof(PartCost));
            }
        }

        public bool CalculatePriceByWeight
        {
            get => _calculatePriceByWeight;
            set
            {
                _calculatePriceByWeight = value;
                HideCalculateByLength = !_calculatePriceByWeight;
                Broadcast(nameof(CalculatePriceByWeight));
            }
        }
        public bool HideCalculateByLength
        {
            get { return _hideCalculateByLength; }
            set
            {
                _hideCalculateByLength = value;
                Broadcast(nameof(HideCalculateByLength));
            }
        }

        #endregion

        private void CalculateByWeight()
        {
            decimal.TryParse(SpoolWeight, out var spoolWeight);
            decimal.TryParse(PartWeight, out var partWeight);
            decimal.TryParse(SpoolCost, out var spoolCost);
            decimal.TryParse(TaxRate, out var taxRate);

            var spool = new SpoolBuilder()
                .WithSpoolCost(spoolCost)
                .WithSpoolWeight(spoolWeight)
                .WithTaxRate(taxRate)
                .Assemble();

            _plasticCostCalculator = new PlasticCostCalculatorBuilder()
                .WithSpool(spool)
                .Assemble();

            PartCost = _plasticCostCalculator
                .CalculateByWeight(partWeight)
                .ToString("C2", _cultureInfo);
        }

        private void CalculateByLength()
        {
            decimal.TryParse(SpoolLength, out var spoolLength);
            decimal.TryParse(PartLength, out var partLength);
            decimal.TryParse(SpoolCost, out var spoolCost);
            decimal.TryParse(TaxRate, out var taxRate);

            var spool = new SpoolBuilder()
                .WithSpoolCost(spoolCost)
                .WithTaxRate(taxRate)
                .WithSpoolLength(spoolLength)
                .Assemble();

            _plasticCostCalculator = new PlasticCostCalculatorBuilder()
                .WithSpool(spool)
                .Assemble();

            PartCost = _plasticCostCalculator
                .CalculateByLength(partLength)
                .ToString("C2", _cultureInfo);
        }

        internal void Calculate()
        {
            if (_calculatePriceByWeight)
            {
                CalculateByWeight();
                return;
            }

            CalculateByLength();
        }

        /// <summary>
        /// Trigger the property update for the databindings.
        /// </summary>
        /// <param name="propertyName"></param>
        private void Broadcast(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
