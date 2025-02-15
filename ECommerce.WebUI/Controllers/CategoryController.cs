﻿using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers;

public class CategoryController(ICategoryService categoryService) : Controller
{
    private readonly ICategoryService _categoryService = categoryService; 
    public IActionResult Index() 
    { 
        var category = _categoryService.GetAll();
        return Json(category);
    }
} //Request ilk once gedir Service layer
  //2.DataAccesLayer
  //3.
  //4.


