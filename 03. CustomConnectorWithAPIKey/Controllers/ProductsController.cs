using Core.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace customconnector.withswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductsRepository _repository;
        public ProductsController(IProductsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet(Name = "GetProducts")]
        public ActionResult<IEnumerable<Product>> Get([FromHeader(Name = "X-API-KEY")] string apiKey = "")
        {
            if (String.IsNullOrEmpty(apiKey))
                return Unauthorized();
            
            if (apiKey != "LETMEIN")
                return Unauthorized();

            return _repository.Get();
        }
    }
}
