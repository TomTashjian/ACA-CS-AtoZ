using ECommerceSystem.Api.Models.RequestModels;
using ECommerceSystem.Api.Models.ResponseModels;
using ECommerceSystem.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceSystem.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        public CategoriesController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public CategoryResponseModel CreateCategory(CategoryRequestModel categoryRequestModel)
        {
            var category = _categoryService.Repo.AddCategory(categoryRequestModel);
            if (_categoryService.Repo.GetCategoryById(category.Id) == null)
            {
                // TODO: might want to change this to return a meaningful error message
                return new CategoryResponseModel();
            }
            return new CategoryResponseModel()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }

        [HttpGet("{id}")]
        public CategoryResponseModel GetCategoryById(int id)
        {
            var category = _categoryService.Repo.GetCategoryById(id);
            if (category == null)
            {
                // TODO: might want to change this to return a meaningful error message
                return new CategoryResponseModel();
            }
            return new CategoryResponseModel()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }

        [HttpPut("{id}")]
        public CategoryResponseModel UpdateCategoryById(int id, [FromBody] CategoryRequestModel categoryRequestModel)
        {
            _categoryService.Repo.UpdateCategoryById(id, categoryRequestModel);
            var category = _categoryService.Repo.GetCategoryById(id);
            if (category == null)
            {
                return new CategoryResponseModel();
            }
            return new CategoryResponseModel()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }
        [HttpDelete("{id}")]
        public void DeleteCategoryById(int id)
        {
            // TODO: might want to handle the case where the category is not found
            _categoryService.Repo.DeleteCategory(id);
        }
    }
}
