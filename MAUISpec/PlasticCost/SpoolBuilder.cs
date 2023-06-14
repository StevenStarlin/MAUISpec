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

        public SpoolBuilder WithSpoolWeight(decimal spoolWeight)
        {
            _spoolWeight = spoolWeight;
            return this;
        }

        public Spool Assemble()
        {
            return new Spool(_spoolWeight);
        }
    }
}
