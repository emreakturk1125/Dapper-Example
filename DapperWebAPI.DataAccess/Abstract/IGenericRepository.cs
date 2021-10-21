using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebAPI.DataAccess.Abstract
{
   public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        Task<int> Add(T item);
        Task<int> Update(T item);
        Task<int> Delete(int id);
        List<T> GetAll();
    }
}
