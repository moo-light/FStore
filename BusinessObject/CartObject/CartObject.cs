using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.CartObject
{
    public class CartObject
    {
        public Dictionary<int, int> Cart { get; set; }
        public  void AddToCart(int productID,int amount = 1) {
            if(Cart.ContainsKey(productID)){
                Cart[productID] += amount;
            }
            else
            {
                Cart.Add(productID, amount);
            }
        }
        public void RemoveFromCart(int productID,int amount = 1)
        {
            if (Cart.ContainsKey(productID))
            {
                Cart[productID] -= amount;
                if (Cart[productID]==0)
                {
                    Cart.Remove(productID);
                }
            }
        }

    }
}
