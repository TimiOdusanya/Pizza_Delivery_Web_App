using ePizzaHub.Entities;
using ePizzaHub.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> GetUserOrders(int UserId);

        int PlaceOrder(int userId, string orderId, string paymentId, CartModel cart, Address address);

    }
}
