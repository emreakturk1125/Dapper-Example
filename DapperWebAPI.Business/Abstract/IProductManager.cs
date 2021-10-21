using DapperWebAPI.Core.Utilities.Results;
using DapperWebAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebAPI.Business.Abstract
{
    public interface IProductManager
    {
        IDataResult<List<Product>> GetAllProducts();
        IDataResult<Product> GetByProductId(int id);
        IDataResult<Task<int>> Add(Product product);


        //Task<Product> GetByProductId(int id);
        //Task<int> AddProduct(Product item);
        //List<Product> GetAllProducts();
    }
}
