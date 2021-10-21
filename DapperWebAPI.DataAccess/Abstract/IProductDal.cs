using DapperWebAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebAPI.DataAccess.Abstract
{
    public interface IProductDal : IGenericRepository<Product>
    {
        
    }
}
