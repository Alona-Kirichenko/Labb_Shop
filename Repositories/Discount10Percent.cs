using System.Collections.Generic;
using shopping.Models;
using System.Linq;
using System;

namespace shopping.Models
{
    public class Discount10Percent : IDiscount10Percent
    {
        public double discountTenPercent(double sumFotForWholeCheck){
            double discount = 0;
            
             if(sumFotForWholeCheck >= 500){
                discount = sumFotForWholeCheck - (sumFotForWholeCheck/10);

                
                Console.WriteLine("\nDiscount 10% Percent  ");
                Console.WriteLine("Old sum: " + sumFotForWholeCheck + "    Sum to pay after 10% discount " + discount +"\n" );


             }
             
             return discount;
            
             }

            
        
    }
}
