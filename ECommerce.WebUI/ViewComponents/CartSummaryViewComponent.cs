﻿using ECommerce.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerce.WebUI.ViewComponents
{
    public class CartSummaryViewComponent(ICartSessionService cartSessionService):ViewComponent
    {
        private readonly ICartSessionService _sessionService= cartSessionService;
        public IViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _sessionService.GetCart()
            };
        return View(model);
        }
       
    }
}
