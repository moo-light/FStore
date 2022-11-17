using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.dao
{
    public class OrderDAO
    {
        private static IOrderRepository _order = new OrderRepository();
        private static IOrderDetailRepository _orderDetail = new OrderDetailRepository();

        public static Boolean CreateOrder(Dictionary<int, int> cart, Member user,decimal freight = 0)
        {
            Order order = new Order()
            {
                MemberId = user.MemberId,
                OrderDate = DateTime.Now,
                Freight = freight 
            };
            _order.Create(order);

            foreach (int productID in cart.Keys)
                if(OrderDetailDAO.CreateOrderDetail(order.OrderId, productID, cart[productID],_orderDetail) != true)
                {

                    return false;
                }
            
            _order.SaveChanges();
            _orderDetail.SaveChanges();
            return true;
        }
    }
}
