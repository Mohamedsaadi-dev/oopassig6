using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopassig6
{
    internal abstract class Discount
    {
        public abstract decimal CalculateDiscount(decimal price, int quantity);
        public abstract string Name { get; }
    }
}
