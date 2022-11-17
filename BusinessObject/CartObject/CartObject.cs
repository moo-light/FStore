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
        void AddToCart(int productID) { }
        void RemoveFromCart(int productID) { }

    }
}
