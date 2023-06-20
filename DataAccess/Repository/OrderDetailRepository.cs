using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class OrderDetailRepository: IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();
        public OrderDetail GetOrderDetailById(int ProductId, int OrderId) => OrderDetailDAO.Instance.GetOrderDetailById(ProductId, OrderId);
        public void InsertOrderDetail(OrderDetail orderdetail) => OrderDetailDAO.Instance.AddNew(orderdetail);
        public void DeleteOrderDetail(int ProductId, int OrderId) => OrderDetailDAO.Instance.Remove(ProductId, OrderId);
        public void UpdateOrderDetail(OrderDetail orderdetail) => OrderDetailDAO.Instance.Update(orderdetail);
    }
}