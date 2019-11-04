using Core.Products;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;

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
        [SwaggerOperation(Summary = "Get products", Description = "Return all products", OperationId = "GetProducts")]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _repository.Get();
        }

        [HttpGet("{id}", Name = "GetProductByName")]
        [SwaggerOperation(Summary = "Get product by name", Description = "Retruns all products that match a specific name", OperationId = "GetProductByName")]
        public ActionResult<IEnumerable<Product>> Get(string id)
        {
            return _repository.Get().Where(p=> p.Id.Equals(id)).ToList();
        }

        [HttpGet("ByRange", Name = "GetProductByPriceRange")]
        [SwaggerOperation(Summary = "Get product by price range", Description = "Returns all products in a specific price range", OperationId = "GetProductByPriceRange")]
        public ActionResult<IEnumerable<Product>> GetByRange([FromQuery]int min, [FromQuery]int max)
        {
            return _repository.Get().Where(p => p.Price >= min && p.Price <= max).ToList();
        }
    }
}
