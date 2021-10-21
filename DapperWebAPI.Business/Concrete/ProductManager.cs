using DapperWebAPI.Business.Abstract;
using DapperWebAPI.Core.Utilities.Results;
using DapperWebAPI.DataAccess.Abstract;
using DapperWebAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebAPI.Business.Concrete
{
    public class ProductManager : IProductManager
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<Task<int>> Add(Product product)
        {
            var result = _productDal.Add(product);
            return new SuccessDataResult<Task<int>>(result); ;
        }

        public IDataResult<List<Product>> GetAllProducts()
        {
            var result = _productDal.GetAll();
            return new SuccessDataResult<List<Product>>(result);

        }

        public IDataResult<Product> GetByProductId(int id)
        {
            var result = _productDal.Get(id);
            return new SuccessDataResult<Product>(result);

        }

    }
}
