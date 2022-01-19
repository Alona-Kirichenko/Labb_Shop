using System.Collections.Generic;
using shopping.Models;
using System.Linq;
using System;

namespace shopping.Models
{
    public class Buy3For2 : IBuy3For2
    {
        // public void discountThreeForTwo(Product product){
             
        //      if(product.Amount % 3 == 0) {
        //      Console.WriteLine("discountThreeForTwo");
            
        //      }

            
        // }

       public void discountThreeForTwo(CartCheck cart){
           double sum = cart.SumOfPrice;
           double discount = 0;

             if(cart.Amount % 3 == 0) {
              sum = sum / 3 ;
              discount = sum + sum;
              cart.Item.Price = discount;

             Console.WriteLine("discountThreeForTwo");
            
             }

        }
    }
}
