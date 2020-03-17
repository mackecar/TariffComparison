using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites
{
    public class Comparator
    {
        public decimal Consumption { get; private set; }
        public string TariffeName { get; private set; }
        public decimal AnnualCost { get; private set; }
    }
}
