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
        void AddToCart(int productID) {
            if(Cart.ContainsKey(productID)){
                Cart[productID] += 1;
            }
            else
            {
                Cart.Add(productID, 1);
            }
        }
        void RemoveFromCart(int productID)
        {
            if (Cart.ContainsKey(productID))
            {
                Cart[productID] -= 1;
                if (Cart[productID]==0)
                {
                    Cart.Remove(productID);
                }
            }
        }

    }
}
