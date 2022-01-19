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
        //    double sumInCart = 0.0; 

           Product candy = new(1, "nice candy", 3.4);
           Product iPhone = new(2, "iPhone 12", 10000.0);


           CartCheck twoCandy = new(2, candy);
           CartCheck twoiphone = new(2, iPhone);
           CartCheck treeiphone = new(3, iPhone);


              
            Cart cart = new Cart();
            cart.AddToCart(twoCandy);
             cart.AddToCart(twoCandy);
            // cart.AddToCart(twoiphone);
            // cart.AddToCart(twoiphone);
            // cart.DeleteFromCart(twoiphone);
           Console.WriteLine("ckeck 1 ");
           cart.myCheck();

           Cart cart2 = new Cart();
             cart2.AddToCart(twoCandy);
            // cart2.AddToCart(treeiphone );
            //  cart2.AddToCart(twoiphone);
            //   cart2.AddToCart(twoiphone);
               Console.WriteLine("ckeck 2 ");
            cart2.myCheck();
               

        //    cart2.DeleteFromCart(twoiphone);
        //     Console.WriteLine("ckeck 2 ");
        //     cart2.myCheck();

        //    cart2.DeleteFromCart(twoiphone);
        //     Console.WriteLine("ckeck 2 ");
        //     cart2.myCheck();

        //     cart2.DeleteFromCart(twoiphone); 
            

           
        //     Console.WriteLine("sumInCart " + sumInCart);

        //     var ckeck = cart.allProductsInMyCart();
            
        }
    }
}
