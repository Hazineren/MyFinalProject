using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _prodactDal;

        public ProductManager(IProductDal prodactDal)
        {
            _prodactDal = prodactDal;
        }

        public List<Product> GetAll()
        {
            // İş Kodları: 
            return _prodactDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _prodactDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _prodactDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _prodactDal.GetProductDetails();
        }
    }
}
