﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //List<Product> GetAll();
        IDataResult<List<Product>> GetAll();
        //List<Product> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        //List<Product> GetAllByUnitPrice(decimal min, decimal max);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
        //List<ProductDetailDto> GetProductDetails();
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        //Product GetById(int productId);
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        

    }
}
