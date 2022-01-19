using System;
using System.Collections.Generic;
namespace shopping.Models{
    public class CartCheck {
     
     public Product Item {get; set;}
      public int Amount {get; set;}
      public double SumOfPrice {get; set;}
      
     

      

      public CartCheck(int amount, Product item){

          Amount = amount;
          Item = item;
          SumOfPrice = item.Price * amount;
         


      }

    }

}