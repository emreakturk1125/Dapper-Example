using Dapper;
using DapperWebAPI.Business.Abstract;
using DapperWebAPI.Entities.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DapperWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {

        IProductManager _productManager;
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productManager.GetAllProducts();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest("Kayıt Bulunamadı");

        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _productManager.GetByProductId(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }

        [HttpPost("add")]
        public IActionResult Add(Product item)
        {
            var result = _productManager.Add(item);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }


    }
}
