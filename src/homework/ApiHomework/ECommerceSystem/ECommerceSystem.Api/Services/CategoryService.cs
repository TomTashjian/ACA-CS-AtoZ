using ECommerceSystem.Api.Repositories;

namespace ECommerceSystem.Api.Services
{
    public class CategoryService
    {
        public readonly CategoriesRepository Repo;
        public CategoryService(CategoriesRepository categoryRepository)
        {
            Repo = categoryRepository;
        }
    }
}
