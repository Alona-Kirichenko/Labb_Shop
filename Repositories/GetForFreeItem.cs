using System.Collections.Generic;
using shopping.Models;
using System.Linq;
using System;

namespace shopping.Models
{
    public class GetForFreeItem : IGetForFreeItem
    {
        public double discountOneItemForFree(List<CartCheck> cart, double sum) {
            double newSum = 0.0;
            if(sum > 2000 && cart.Count >= 3){
                //  double lowest_price = cart.Min(c => c.Item.Price);
                //  CartCheck prouctWithMinPrice = cart.Find(p => p.Item.Price == lowest_price);

                //  newSum = sum - prouctWithMinPrice.SumOfPrice;
                //  prouctWithMinPrice.SumOfPrice = 0.0;

                //  Console.WriteLine("You get for free: " + prouctWithMinPrice.Item.Name  + " " + prouctWithMinPrice.SumOfPrice );

            ///////////////////////////////////////////////////

             double lowest_price = cart.Min(c => c.SumOfPrice);
               newSum = sum - lowest_price;

                CartCheck prouctWithMinPrice = cart.Find(p => p.SumOfPrice == lowest_price);

                prouctWithMinPrice.SumOfPrice = 0.0;

                Console.WriteLine("\nDiscount get 1 item for free if sum is more than 20000 € ");
                 Console.WriteLine("You get for free: " + prouctWithMinPrice.Item.Name  + "    Price per one item: " + prouctWithMinPrice.Item.Price + "€      Now you pay:  " + prouctWithMinPrice.SumOfPrice + "€");



            }
            return newSum;
                  
              
        }

            
        
    }
}
