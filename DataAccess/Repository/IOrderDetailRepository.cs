using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailById(int ProductId, int OrderId);
        void InsertOrderDetail(OrderDetail orderdetail);
        void DeleteOrderDetail(int ProductId, int OrderId);
        void UpdateOrderDetail(OrderDetail orderdetail);
    }
}