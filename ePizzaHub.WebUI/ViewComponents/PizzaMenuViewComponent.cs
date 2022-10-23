using ePizzaHub.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePizzaHub.WebUI.ViewComponents
{
    public class PizzaMenuViewComponent : ViewComponent
    {
        ICatalogService _catalogService;

        public PizzaMenuViewComponent(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        public IViewComponentResult Invoke()
        {
            var items = _catalogService.GetItems();
            return View("~/Views/Shared/_PizzaMenu.cshtml",items);
        }
    }
}
