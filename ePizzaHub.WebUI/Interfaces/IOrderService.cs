using ePizzaHub.Entities;
using ePizzaHub.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePizzaHub.WebUI.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> GetUserOrders(int UserId);

        int PlaceOrder(int userId, string orderId, string paymentId, CartModel cart, Address address);
    }
}
