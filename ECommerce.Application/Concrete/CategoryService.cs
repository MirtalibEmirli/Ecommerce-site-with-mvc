using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Concrete;

public class CategoryService : ICategoryService
{
    private readonly ICategoryDal _categoryDal;//dal

    public CategoryService(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
   
    public List<Category> GetAll()
    {
        return _categoryDal.GetList();
        //burda bizim buissnes logic comes and we do it but we need acces that's why we send request to the DataAccesLayer,indi request is going to Dal
    }
}
