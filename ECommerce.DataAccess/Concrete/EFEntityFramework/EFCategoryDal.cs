using ECommerce.DataAcces.Context;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;
using ECommerce.Repository.DataAcces.EntityFrameWorkAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Concrete.EFEntityFramework;

public class EFCategoryDal : EFEntityRepositoryBase<Category, NorthWindDbContext>, ICategoryDal
{


}
