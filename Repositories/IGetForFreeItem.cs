using System.Collections.Generic;
using shopping.Models;
using System.Linq;
using System;

namespace shopping.Models
{
    public interface IGetForFreeItem
    {
         double discountOneItemForFree(List<CartCheck> cart, double sum);
    }
}
