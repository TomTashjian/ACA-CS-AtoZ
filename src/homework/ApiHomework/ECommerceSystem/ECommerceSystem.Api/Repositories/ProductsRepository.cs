using ECommerceSystem.Api.Entities;
using ECommerceSystem.Api.Models.RequestModels;

namespace ECommerceSystem.Api.Repositories
{
    public class ProductsRepository
    {
        private List<Product> _products { get; set; }
        private int _nextId { get; set; }

        public ProductsRepository()
        {
            _products = new List<Product>();
            _nextId = 1;
        }

        public Product AddProduct(ProductRequestModel productRequestModel)
        {
            _products.Add(new Product
            {
                Id = _nextId,
                Name = productRequestModel.Name,
                Price = productRequestModel.Price
            });
            _nextId++;
            return _products[_nextId - 2];
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public void UpdateProductById(int id, ProductRequestModel productRequestModel)
        {
            var productToUpdate = _products.FirstOrDefault(p => p.Id == id);
            if (productToUpdate != null)
            {
                productToUpdate.Name = productRequestModel.Name;
                productToUpdate.Price = productRequestModel.Price;
            }
        }

        public void DeleteProduct(int id)
        {
            var productToDelete = _products.FirstOrDefault(p => p.Id == id);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
            Reorder();
            _nextId--;
        }

        #region Private Methods
        private void Reorder()
        {
            for (int i = 0; i < _products.Count; i++)
            {
                _products[i].Id = i + 1;
            }
        }
        #endregion
    }
}
