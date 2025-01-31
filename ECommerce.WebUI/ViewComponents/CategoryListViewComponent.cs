using ECommerce.Application.Abstract;
using ECommerce.Application.Concrete;
using ECommerce.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.ViewComponents
{
    public class CategoryListViewComponent(ICategoryService categoryService) :ViewComponent
    {
        private readonly ICategoryService _categoryService=categoryService;

        public IViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
    }
}
