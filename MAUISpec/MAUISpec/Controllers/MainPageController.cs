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
        private string _partWeight;
        private string _spoolWeight = "1000";
        private string _spoolCost = "22.99";
        private string _taxRate = "6";
        private string _partCost = "0.00";

        public event PropertyChangedEventHandler PropertyChanged;

        public string PartWeight
        {
            get => _partWeight;
            set
            { 
                _partWeight = value;
                Broadcast(nameof(PartWeight));
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

        private PlasticCostCalculator _plasticCostCalculator;

        internal void Calculate()
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
                .Calculate(partWeight)
                .ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
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
