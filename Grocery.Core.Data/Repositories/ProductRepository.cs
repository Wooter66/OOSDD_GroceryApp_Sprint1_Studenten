using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product { Id = 1, Name = "Melk", Stock = 300 },
                new Product { Id = 2, Name = "Kaas", Stock = 100 },
                new Product { Id = 3, Name = "Brood", Stock = 400 },
                new Product { Id = 4, Name = "Cornflakes", Stock = 0 }
            }
        }
        public List<Product> GetAll()
        {
            return products; // return the initialized list
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
