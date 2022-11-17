using BusinessObject.Models;
using System;
using System.Diagnostics.Metrics;

public interface IOrderDetailRepository
{
    IEnumerable<Order> GetAlls();
    Order Get(int orderID ,int productID);
    void Create(Order o);
    void Update(Order o);
    void Remove(Order o);
    void CreateNoSave(Order o);
    void SaveChanges();
}
