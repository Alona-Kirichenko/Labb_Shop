using System.Collections.Generic;
using shopping.Models;
using System.Linq;

namespace shopping.Models
{
    public interface IBuy3For2
    {
       
        void discountThreeForTwo(List<CartCheck> cart);
    }
}
