using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new Object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            var orderdetails = new List<OrderDetail>();
            try
            {
                using var context = new ASSIGNMENT1Context();
                orderdetails = context.OrderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderdetails;
        }


        public OrderDetail GetOrderDetailById(int ProductId, int OrderId)
        {
            OrderDetail orderdetail = null;
            try
            {
                using var context = new ASSIGNMENT1Context();
                orderdetail = context.OrderDetails.SingleOrDefault(c => c.ProductId == ProductId && c.OrderId == OrderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderdetail;
        }

        public void AddNew(OrderDetail orderdetail)
        {
            try
            {
                OrderDetail _orderdetail = GetOrderDetailById(orderdetail.ProductId, orderdetail.OrderId);
                if (_orderdetail == null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.OrderDetails.Add(orderdetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The orderdetail is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(OrderDetail orderdetail)
        {
            try
            {
                OrderDetail _orderdetail = GetOrderDetailById(orderdetail.ProductId, orderdetail.OrderId);
                if (_orderdetail != null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.OrderDetails.Update(orderdetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The orderdetail does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int ProductId, int OrderId)
        {
            try
            {
                OrderDetail orderdetail = GetOrderDetailById(ProductId, OrderId);
                if (orderdetail != null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.OrderDetails.Remove(orderdetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The orderdetail does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}