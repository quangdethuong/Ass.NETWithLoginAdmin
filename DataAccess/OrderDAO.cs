using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new Object();
        public static OrderDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Order> GetOrderList()
        {
            var orders = new List<Order>();
            try
            {
                using var context = new ASSIGNMENT1Context();
                orders = context.Orders.ToList();
                if (orders != null) {
                    foreach(var item in orders) {
                        var c = context.Entry(item);
                        c.Reference(ci => ci.Member).Load();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }


        public Order GetOrderById(int OrderId)
        {
            Order order = null;
            try
            {
                using var context = new ASSIGNMENT1Context();
                order = context.Orders.SingleOrDefault(c => c.OrderId == OrderId);
                if (order != null) {
                    var e = context.Entry(order);
                    e.Collection(c => c.OrderDetails).Load();
                    foreach(var item in order.OrderDetails) {
                        var c = context.Entry(item);
                        c.Reference(ci => ci.Product).Load();
                    }
                    e.Reference(c => c.Member).Load();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }
        

        public void AddNew(Order order)
        {
            try
            {
                Order _order = GetOrderById(order.OrderId);
                if (_order == null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The order is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Order order)
        {
            try
            {
                Order _order = GetOrderById(order.OrderId);
                if (_order != null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The order does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int orderID)
        {
            try
            {
                Order order = GetOrderById(orderID);
                if (order != null)
                {
                    using var context = new ASSIGNMENT1Context();
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The order does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}