using System;
using System.Collections.Generic;
using shopping.Repositories;
using System.Linq;
using shopping.Models;

namespace shopping.Models
{
    public class Cart : ICart 
    {
       
        public List<CartCheck> MyCheck;
       
    public Cart()
    {
        MyCheck = new List<CartCheck>();
    }
    public List<CartCheck> GetListCart(){
        return  MyCheck;
    }
        
    
       public void myCheck(){

           foreach (CartCheck item in MyCheck){
               Console.WriteLine( "Name: "+ item.Item.Name + " " + "  amount: "+ item.Amount+ "  PricePerOne: " + item.Item.Price + "€" + "  Total: " + item.SumOfPrice + "€");

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

            
            
            
         }

         public void DeleteFromCart(int id){
            
             var itemToRemove = MyCheck.Find(item => item.Item.Id  == id);
                if (itemToRemove != null)
                {
                    Console.WriteLine("itemToRemove" + itemToRemove);
                    MyCheck.Remove(itemToRemove);
                }
  
         }

          public double SumForAllCart(double sumAfterDiscount, bool showTheCheck){
              double sum = 0;
              string name = "";
              int amount = 0;
              double prise = 0.0;
              double sumOfItemsPrice= 0.0;

           
                
                 foreach (CartCheck item in  MyCheck){
                    
                     
                       sum = sum + item.SumOfPrice;
                 }
                       if(sumAfterDiscount != 0.0){
                           sum = sumAfterDiscount;
                         
                       }
                    
                        if (showTheCheck) {
                              Console.WriteLine("********************************************************************");
                              Console.WriteLine("                                                                  ");
                               Console.WriteLine("                       <3      CHECK      <3              ");
                               Console.WriteLine("                                                                  ");
                 
                 for(int i = 0; i < MyCheck.Count;  i++ ){
                  var itemIn = MyCheck[i];
                  name = itemIn.Item.Name;
                  amount = itemIn.Amount;
                  prise = itemIn.Item.Price;
                  sumOfItemsPrice = itemIn.SumOfPrice;
                   

                  Console.WriteLine( "* Name: "+ name + " " + "  amount: "+ amount+ "  PricePerOne: " + prise + "€" + "  Total: " + sumOfItemsPrice + "€");
                 }
               

              if(sumAfterDiscount != 0.0 && showTheCheck){
                    Console.WriteLine("\n* TOTAL SUM TO PLAY AFTER ALL DICTOUNTS:    " + sum);

              } else{
                    Console.WriteLine("\n* TOTAL SUM TO PLAY BEFORE DISCOUNT:    " + sum);

              }
            

               Console.WriteLine("                                                                  ");

                Console.WriteLine("********************************************************************");
                        }

           
           return sum;

          }

         
   

    }
}