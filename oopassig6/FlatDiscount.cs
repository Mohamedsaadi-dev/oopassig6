using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopassig6
{
    internal class FlatDiscount:Discount
    {
        private decimal _flatAmount;

        public FlatDiscount(decimal flatAmount)
        {
            _flatAmount = flatAmount;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return _flatAmount * Math.Min(quantity, 1);
        }

        public override string Name => $"Flat ${_flatAmount} Discount";
    }
}
