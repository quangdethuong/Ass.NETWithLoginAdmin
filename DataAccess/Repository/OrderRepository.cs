using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class OrderRepository: IOrderRepository
    {
        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList();
        public Order GetOrderById(int orderId) => OrderDAO.Instance.GetOrderById(orderId);
        public void InsertOrder(Order order) => OrderDAO.Instance.AddNew(order);
        public void DeleteOrder(int orderId) => OrderDAO.Instance.Remove(orderId);
        public void UpdateOrder(Order order) => OrderDAO.Instance.Update(order);
    }
}