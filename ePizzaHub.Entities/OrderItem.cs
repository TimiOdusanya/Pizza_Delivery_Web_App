using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Entities
{
    public class OrderItem
    {
        private OrderItem()
        {
            //required by EF
        }

        public OrderItem(int itemId, decimal unitPrice, int quantity, decimal total)
        {
            ItemId = itemId;
            Unitprice = unitPrice;
            Quantity = quantity;
            Total = total;

        }

        public int Id { get; set; }
        public int ItemId { get; set; }
        public decimal Unitprice { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}
