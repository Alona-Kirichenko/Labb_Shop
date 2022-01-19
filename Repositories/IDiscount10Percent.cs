using System.Collections.Generic;
using shopping.Models;
using System.Linq;

namespace shopping.Models
{
    public interface IDiscount10Percent
    {
        int discountTenPercent(int sumFotForWholeCheck);
    }
}
