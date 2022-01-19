using System;
using System.Collections.Generic;
using shopping.Models;
using System.Linq;

namespace shopping.Repositories
{
    public interface ICart
    {   
        
        void myCheck();
         void AddToCart(CartCheck productAndAmount);
        void DeleteFromCart(CartCheck productAndAmount);

        void SumForAllCart( List<CartCheck> userCart);


        

       
    }
}