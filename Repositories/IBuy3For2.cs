using System.Collections.Generic;
using shopping.Models;
using System.Linq;

namespace shopping.Models
{
    public interface IBuy3For2
    {
        // void discountThreeForTwo(Product product);
        void discountThreeForTwo(CartCheck cart);
    }
}
