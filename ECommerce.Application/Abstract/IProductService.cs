﻿using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Abstract;

public interface IProductService
{
    List<Product> GetAll();
    List<Product> GetAllByCategory(int CategoryId);
    Product GetById(int id);
    public void Add(Product product);
    public void Update(Product product);
    public void Delete(int id);

}
