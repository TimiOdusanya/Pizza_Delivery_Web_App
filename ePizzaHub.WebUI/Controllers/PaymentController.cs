using ePizzaHub.Repositories.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ePizzaHub.WebUI.Helpers;
using ePizzaHub.WebUI.Models;
using ePizzaHub.Services.Models;
using ePizzaHub.Services.Interfaces;
using Microsoft.Extensions.Options;
using ePizzaHub.WebUI.Interfaces;
using Microsoft.AspNetCore.Http;
using ePizzaHub.Entities;

using Microsoft.AspNetCore.Identity;
using IOrderService = ePizzaHub.Services.Interfaces.IOrderService;

namespace ePizzaHub.WebUI.Controllers
{
    public class PaymentController : Controller
    {

        //key_id: rzp_test_dlnW9bJUmfXtU3
        //Key_ Secret: GqXw3oExUdReKBWOZAfwXjMf
        //Master Card: 5104 0600 0000 0008 
        //Visa: 4111 1111 1111 1111

        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;
        public PaymentController(IOrderService _orderService, ICartService cartService)
        {
            this._orderService = _orderService;
            this._cartService = cartService;
        }

        Guid CartId
        {
            get
            {
                Guid Id;
                string CId = Request.Cookies["CId"];
                if (string.IsNullOrEmpty(CId))
                {
                    Id = Guid.NewGuid();
                    Response.Cookies.Append("CId", Id.ToString());
                }
                else
                {
                    Id = Guid.Parse(CId);
                }
                return Id;
            }
        }

        public IActionResult Index()
        {
            PaymentModel payment = new PaymentModel();
            CartModel cart = TempData.Peek<CartModel>("Cart");
            if (cart != null)
            {
                payment.Cart = cart;
            }
            payment.GrandTotal = Math.Round(cart.GrandTotal);
            payment.Currency = "Naira";
            string items = "";
            foreach (var item in cart.Items)
            {
                items += item.Name + ",";
            }
            payment.Description = items;
            payment.Receipt = Guid.NewGuid().ToString();
           // payment.OrderId = _pay

            return View(payment);


        }


       // [HttpPost]

        
        public IActionResult Receipt()
        {
            PaymentDetails model = TempData.Peek<PaymentDetails>("PaymentDetails");
            return View(model);
            
        }


        public IActionResult SaveOrder(PaymentModel paymentModel)
        {
            Address address = new Address()
            {
                City = "",
                UserId = paymentModel.userId,
                

            };
            var cart = paymentModel.Cart;
            var result = _orderService.PlaceOrder(paymentModel.userId,paymentModel.Razorpaykey,paymentModel.Razorpaykey, cart,address);
            if (result > 0)
            {
                return Json("Order Saved Successfully");
            }
            else
            {
                return Json("An Error Occurred while Attempting to Save Order");
            }
            
        }

    }
}
