using Dapper;
using DapperWebAPI.DataAccess.Abstract;
using DapperWebAPI.Entities.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebAPI.DataAccess.Concrete
{
    public class ProductDal : IProductDal
    {
        private readonly IConfiguration _configuration;
        public ProductDal(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Add(Product item)
        {
            var sql = "insert into products (ProductName,UnitPrice, UnitsInStock) values (@ProductName,@UnitPrice,@UnitsInStock);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRow = await connection.ExecuteAsync(sql, item);
                return affectedRow;
            }
        }

        public async Task<int> Delete(int id)
        {
            var sql = "delete from products where ProductID=@ProductID;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRow = await connection.ExecuteAsync(sql, new { ProductID = id });
                return affectedRow;
            }
        }

        public Product Get(int id)
        {
            var sql = "select * from products where ProductID=@ProductID;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result =  connection.Query<Product>(sql, new { ProductID = id });
                return result.FirstOrDefault();
            }
        }

        public  List<Product> GetAll()
        {
            var sql = "select * from products;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = connection.Query<Product>(sql).ToList();
                return result;
            }
        }

        public async Task<int> Update(Product item)
        {
            var sql = "update products set (ProductName=@ProductName,UnitPrice=@UnitPrice, UnitsInStock=@UnitsInStock) where ProductID=@ProductID;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRow = await connection.ExecuteAsync(sql, item);
                return affectedRow;
            }
        }

         
    }
}
