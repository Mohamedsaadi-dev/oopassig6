using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopassig6
{
    internal class BuyOneGetOneDiscount:Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
            {
                return (price / 2) * (quantity / 2);
            }
            return 0;
        }

        public override string Name => "Buy One Get One 50% Discount";
    }
}
