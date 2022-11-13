using BusinessObject.Models;
using System;
using System.Diagnostics.Metrics;

public interface IOrderDetailRepository
{
    IEnumerable<OrderDetail> GetAlls();
    OrderDetail Get(int orderID ,int productID);
    void Create(OrderDetail o);
    void Update(OrderDetail o);
    void Remove(OrderDetail o);
}
