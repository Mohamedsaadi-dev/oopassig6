using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopassig6
{
    internal class PercentageDiscoun:Discount
    {
        private decimal _percentage;

        public PercentageDiscount(decimal percentage)
       {
            _percentage = percentage;
       }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (_percentage / 100);
        }

        public override string Name => $"{_percentage}% Discount";
    }
}
