using ECommerceSystem.Api.Entities;
using ECommerceSystem.Api.Models.RequestModels;

namespace ECommerceSystem.Api.Repositories
{
    public class CategoriesRepository
    {
        private List<Category> _categories { get; set; }
        private int _nextId { get; set; }

        public CategoriesRepository()
        {
            _categories = new List<Category>();
            _nextId = 1;
        }

        public Category AddCategory(CategoryRequestModel categoryRequestModel)
        {
            var category = new Category
            {
                Id = _nextId,
                Name = categoryRequestModel.Name,
                Description = categoryRequestModel.Description
            };
            _categories.Add(category);
            _nextId++;
            return category;
        }

        public Category? GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> GetCategories()
        {
            return _categories;
        }

        public void UpdateCategoryById(int id, CategoryRequestModel categoryRequestModel)
        {
            var categoryToUpdate = _categories.FirstOrDefault(c => c.Id == id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = categoryRequestModel.Name;
                categoryToUpdate.Description = categoryRequestModel.Description;
            }
        }

        public void DeleteCategory(int id)
        {
            var categoryToDelete = _categories.FirstOrDefault(c => c.Id == id);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }
            Reorder();
            _nextId--;
        }

        #region Private Methods
        private void Reorder()
        {
            for (int i = 0; i < _categories.Count; i++)
            {
                _categories[i].Id = i + 1;
            }
        }
        #endregion
    }
}
