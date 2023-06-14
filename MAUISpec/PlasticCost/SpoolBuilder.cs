using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasticCost
{
    public class SpoolBuilder
    {
        private decimal _spoolWeight;
        private decimal _spoolCost;

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

        public Spool Assemble()
        {
            return new Spool(_spoolWeight, _spoolCost);
        }
    }
}
