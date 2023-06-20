using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class OrderDetail
    {
        public OrderDetail(int orderId, int productId, decimal unitPrice, int quantity, double discount)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
