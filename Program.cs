using System;
using shopping.Models;
using System.Collections.Generic;
using System.Linq;

namespace shopping

{
    class Program
    {
        static void Main(string[] args)
        {
    
             string answer = "";
             int amount = 0;
            
           Product gum = new(1, "Hubba Bubba", 5.0);
           Product iPhone = new(2, "iPhone 12", 2000.0);
           Product bag = new(3, "Gucci", 1000.0 );

           Cart cart = new Cart();
           
           string menuOption(){
               Console.WriteLine("********************************************************************");
                Console.WriteLine("*                                                                  *");
                Console.WriteLine("*                 <3      Welcome to our store      <3             * ");
                Console.WriteLine("*                                                                  *");
                 Console.WriteLine("* Press:                                                           *");
                Console.WriteLine("* (1) To buy iPhone 12  / (2) To delete                            *\n* (3) To buy GUCCI bag / (4) To delete                             *\n* (5) To buy a gum / (6) To delete                                 *\n* (7) To pay                                                       *\n*                                                                  *");
                Console.WriteLine("*                                                                  *");

                Console.WriteLine("********************************************************************");
                answer = Console.ReadLine();
                 Console.WriteLine("You pressed: " + answer);
                return answer;
               
               
           }

           void menu(){
               menuOption();
                {
                    
                if (answer == "1")
                {
                    
                    addIphoneToCart();

                    
                }
                else if (answer == "2")
                {
                     deleteIphone();
                }
                else if (answer == "3")
                {
                 addBag();
                  
                }
                else if (answer == "4")
                {
                    deleteBag();
                }

                else if (answer == "5")
                {
                   addGum();    
                    
                } else if(answer == "6"){
                    deleteGum();

                }else if(answer == "7"){
                     allDiscount();


                }
                else

                {
                    Console.WriteLine("You can only choose between 1, 2, 3 , 4,5, 6 and 7");
                   
                }
                 
                menuOption();

            }

           }
           menu();

           void addIphoneToCart() {
               Console.WriteLine("Write amount: ");
                    amount = Int32.Parse(Console.ReadLine());
                   CartCheck addIphone = new(amount, iPhone);
                    cart.AddToCart(addIphone);
                   cart.SumForAllCart(0.0, true);
                    
                    menu();
           };

           void deleteIphone(){
                cart.DeleteFromCart(2);
                cart.SumForAllCart(0.0, true);
                 menu();      
           };
            

            void addBag(){
                  Console.WriteLine("Write amount: ");
                    amount = Int32.Parse(Console.ReadLine());
                    CartCheck addBag = new(amount, bag);
                    cart.AddToCart(addBag );
                    cart.SumForAllCart(0.0, true);   
                    menu();          
                  }
            void deleteBag(){
                cart.DeleteFromCart(3);
                cart.SumForAllCart(0.0, true);
                 menu();      
           };
            

            void addGum(){
                Console.WriteLine("Write amount: ");
                    amount = Int32.Parse(Console.ReadLine());
                    CartCheck addGum = new(amount, gum);
                    cart.AddToCart(addGum );
                     cart.SumForAllCart(0.0, true);
                    menu();
                     
            }
              void deleteGum(){
                cart.DeleteFromCart(1);
                cart.SumForAllCart(0.0, true);
                 menu();      
           };
            

            void allDiscount(){
                Console.WriteLine("*********************DISCOUNT*******************");
                
                  double sumForAll =  cart.SumForAllCart(0.0,false);   
                  var car2List = cart.GetListCart();
                  Buy3For2 buy3For2 = new Buy3For2(); 
                  buy3For2.discountThreeForTwo(car2List);
                  double sumAfterDiscount3For2 = cart.SumForAllCart(0.0, false); 


                  GetForFreeItem getForFreeItem = new GetForFreeItem();
                  getForFreeItem.discountOneItemForFree(car2List,sumAfterDiscount3For2); 
                  double sumAfterDiscount1ItemForFree = cart.SumForAllCart(0.0, false); 

                     
                 Discount10Percent discount10Percent = new Discount10Percent(); 
                 var discount10P = discount10Percent.discountTenPercent(sumAfterDiscount1ItemForFree);
                  sumForAll = cart.SumForAllCart(discount10P, true);   

            };
            
        }
    }
}
