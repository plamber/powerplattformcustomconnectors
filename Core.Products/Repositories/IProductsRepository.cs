using System.Collections.Generic;

namespace Core.Products
{
    public interface IProductsRepository
    {
        List<Product> Get();
    }
}
