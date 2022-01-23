using System;
using System.Collections.Generic;
using shopping.Models;
using System.Linq;

namespace shopping.Repositories
{
    public interface ICart
    {   

        
        void myCheck();
        List<CartCheck> GetListCart();
         void AddToCart(CartCheck productAndAmount);
       
          void DeleteFromCart(int id);

        double SumForAllCart( double sumAfterDiscount, bool showTheCheck);


        

       
    }
}