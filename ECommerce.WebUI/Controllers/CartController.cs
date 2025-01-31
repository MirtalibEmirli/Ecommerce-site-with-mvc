using ECommerce.Application.Abstract;
using ECommerce.WebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers;

public class CartController(ICartSessionService cartSessionService, IProductService productService) : Controller
{
    private readonly ICartSessionService _cartSessionService;
    private readonly IProductService _productService;
    public IActionResult Index()
    {
        return View();
    }
}