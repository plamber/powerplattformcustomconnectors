using System.Collections.Generic;

namespace Core.Products
{
    public class ProductsRepository : IProductsRepository
    {
        public List<Product> Get()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = "SURPROX", Name = "Surface Pro X", Price = 999, Description = "Edge to edge 2-in-1 laptop with LTE" });
            products.Add(new Product() { Id = "SURBUD", Name = "Surface Earbuds", Price = 249, Description = "Premium sound, fit and screen-free control" });
            products.Add(new Product() { Id = "SURPRO7", Name = "Surface Pro 7", Price = 749, Description = "Tablet-to-laptop versatility" });
            products.Add(new Product() { Id = "SURLAP3", Name = "Surface Laptop 3", Price = 999, Description = "Slim and stylish" });
            products.Add(new Product() { Id = "SURBOOK2", Name = "Surface Book 2", Price = 1049, Description = "Our most powerful touchscreen laptop" });
            products.Add(new Product() { Id = "SURSTUD2", Name = "Surface Studio 2", Price = 3499, Description = "Brilliant color, blazing graphics" });
            products.Add(new Product() { Id = "SURGO", Name = "Surface Go", Price = 399, Description = "Smallest, lightest Surface" });
            products.Add(new Product() { Id = "SURHEAD", Name = "Surface Headphones", Price = 349, Description = "Spectacular sound, comfort, and active noise cancellation" });
            return products;
        }
    }
}
