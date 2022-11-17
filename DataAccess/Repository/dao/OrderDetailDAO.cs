using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.dao
{
    public class OrderDetailDAO
    {
        internal static Boolean CreateOrderDetail(int orderId, int productID, int quantity, IOrderDetailRepository _orderDetail
            ,IProductRepository _product)
        {   
            var orderDetail = new OrderDetail()
            {
                OrderId = orderId,
                ProductId = productID,
                Quantity = quantity,
                UnitPrice = ProductDAO.GetAlls().FirstOrDefault(x=>x.ProductId==productID).UnitPrice,
                Discount = 0.1
            };

            _orderDetail.CreateNoSave(orderDetail);
            ProductDAO.UpdateQuantity(productID, quantity,_product);
            return true;
        }
    }
}
