using System.Collections.Generic;
using shopping.Models;
using System.Linq;
using System;

namespace shopping.Models
{
    public class Discount10Percent : IDiscount10Percent
    {
        public int discountTenPercent(int sumFotForWholeCheck){
            var discount = 0;
             if(sumFotForWholeCheck >= 500){
                discount = sumFotForWholeCheck - (sumFotForWholeCheck/10);

             }
            return discount;
             }

            
        
    }
}
