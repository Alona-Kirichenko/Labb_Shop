using System;
using System.Collections.Generic;
using shopping.Repositories;
using System.Linq;
using shopping.Models;

namespace shopping.Models
{
    public class Cart : ICart 
    {
        // public List<Product> MyCart = new List<Product>();
        public List<CartCheck> MyCheck;
       
    public Cart()
    {
        MyCheck = new List<CartCheck>();
    }

        
    //    public List<Product> allProductsInMyCart(){return MyCart;}
       public void myCheck(){

           foreach (CartCheck item in MyCheck){
               Console.WriteLine( "Name: "+ item.Item.Name + " " + "  amount: "+ item.Amount+ "  PricePerOne: " + item.Item.Price + "  Total: " + item.SumOfPrice + " €");

           }
           
           }
        public void AddToCart(CartCheck productAndAmount){

            bool containsItem = MyCheck.Any(item => item.Item.Id  == productAndAmount.Item.Id);
          

           if(containsItem == true){
          CartCheck ifProductExist = MyCheck.Find(item => item.Item.Id == productAndAmount.Item.Id);

          ifProductExist.SumOfPrice = ifProductExist.SumOfPrice + productAndAmount.SumOfPrice; 

          ifProductExist.Amount = ifProductExist.Amount + productAndAmount.Amount;
           } else {
               MyCheck.Add(productAndAmount);

           }


        //    foreach (CartCheck item in MyCheck){
        //        CartCheck ifProductExist = MyCheck.Find(item => item.Item.Id == productAndAmount.Item.Id);
        //     //    if(ifProductExist.Item.Id )
             

        //    }
            
            
            
         }

         public void DeleteFromCart(CartCheck productAndAmount){

             bool containsItem = MyCheck.Any(item => item.Item.Id  == productAndAmount.Item.Id);

          if(containsItem == true){

          CartCheck ifProductExist = MyCheck.Find(item => item.Item.Id == productAndAmount.Item.Id);

          if(ifProductExist.Amount > productAndAmount.Amount ){

           Console.WriteLine("ifProductExist.Amount > productAndAmount.Amount" + ifProductExist.Amount + " " + productAndAmount.Amount);

          ifProductExist.SumOfPrice = ifProductExist.SumOfPrice - productAndAmount.SumOfPrice ; 

          ifProductExist.Amount = ifProductExist.Amount - productAndAmount.Amount  ;

          } else if (ifProductExist.Amount == productAndAmount.Amount ) {
            //    CartCheck deleteProduct = MyCheck.Find(item => item.Item.Id == productAndAmount.Item.Id);
             MyCheck.Remove(ifProductExist);

          }
          else{
               Console.WriteLine("ifProductExist.Amount > productAndAmount.Amount" + ifProductExist.Amount + " " + productAndAmount.Amount);
              Console.WriteLine("You want to take away more than exist in your cart");
          }


           } else {
               Console.WriteLine("You dont have this product in your cart");

           }

            
         }

          public void SumForAllCart( List<CartCheck> userCart){
              foreach (CartCheck item in userCart){

               Console.WriteLine("THIS IS SUM" + item.SumOfPrice);

           }

          }

         
    //    public double DeleteFromCart(Product product, double sum){
    //        Product deleteProduct = MyCart.Find(item => item == product);
    //        MyCart.Remove(deleteProduct);
    //        return sum = sum - product.Price;
    //    }

    }
}