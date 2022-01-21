using System.Collections.Generic;
using shopping.Models;
using System.Linq;
using System;

namespace shopping.Models
{
    public class Buy3For2 : IBuy3For2
    {
      
       public void discountThreeForTwo(List<CartCheck> cart){
           
              for (int j = 0; j< cart.Count; j++){

              if(cart[j].Amount > 2){
                  double newSum = 0.0;
                  double sumOfItem = cart[j].SumOfPrice ;
                  double restFromModulus = cart[j].Item.Price;
                   
                   if(cart[j].Amount % 3 == 0){
                       
                        sumOfItem  = sumOfItem / 3;
                        newSum = sumOfItem + sumOfItem;
                        cart[j].SumOfPrice = newSum;

                   } else if(cart[j].Amount % 3 == 1){
                        
                        sumOfItem = sumOfItem - restFromModulus;
                        sumOfItem  = sumOfItem / 3;
                        newSum = sumOfItem + sumOfItem + restFromModulus;
                        cart[j].SumOfPrice = newSum; 

                   }else if(cart[j].Amount % 3 == 2){
                        sumOfItem = sumOfItem - (restFromModulus * 2);
                        sumOfItem  = sumOfItem / 3;
                        newSum = sumOfItem + sumOfItem +(restFromModulus * 2);
                        cart[j].SumOfPrice = newSum;

                   } else {
                       Console.WriteLine("Something strange is going on in discountOneItemForFree!");
                   }
                   Console.WriteLine("\nDiscount pay for 2 and get 3");
                   Console.WriteLine("Product: " + cart[j].Item.Name + " Amount: " + cart[j].Amount + "   Price per one item: "+cart[j].Item.Price  +"    Total price: "  + cart[j].SumOfPrice + " €");
                  
               }
               

             } 
         }   
    }
}
