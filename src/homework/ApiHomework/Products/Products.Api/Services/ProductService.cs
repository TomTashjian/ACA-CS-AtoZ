using ECommerceSystem.Api.Repositories;

namespace ECommerceSystem.Api.Services
{
    public class ProductService
    {
        public readonly ProductsRepository Repo;
        public ProductService(ProductsRepository productsRepository)
        {
            Repo = productsRepository;
        }

    }
}