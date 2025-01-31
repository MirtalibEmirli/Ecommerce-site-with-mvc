using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class ProductController(IProductService prouductService) : Controller
    {
        private readonly IProductService _prouductService= prouductService;
             
       
        public IActionResult Index(int page=1 ,int categoryId=0)
        {
            int pageSize = 10;
            var products = _prouductService.GetAllByCategory(categoryId);
            //bax
            var pagedProducts = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var model = new ProductListViewModel{
                 CurrentCategory=categoryId,
                 PageCount=(int)Math.Ceiling(products.Count/(double)(pageSize)),
                 PageSize=pageSize,
                 CurrentPage=page,
                 Products= pagedProducts

            };
            return View(model);
        }
    }
}
