using ECommerceSystem.Api.Models.RequestModels;
using ECommerceSystem.Api.Models.ResponseModels;
using ECommerceSystem.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceSystem.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public ProductResponseModel CreateProduct(ProductRequestModel productRequestModel)
        {
            var product = _productService.Repo.AddProduct(productRequestModel);
            if (_productService.Repo.GetProductById(product.Id) == null)
            {
                // TODO: might want to change this to return a meaningful error message
                return new ProductResponseModel();
            }
            return new ProductResponseModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

        [HttpGet("{id}")]
        public ProductResponseModel GetProductById(int id)
        {
            var product = _productService.Repo.GetProductById(id);
            if (product == null)
            {
                // TODO: might want to change this to return a meaningful error message
                return new ProductResponseModel();
            }
            return new ProductResponseModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

        [HttpPut("{id}")]
        public ProductResponseModel UpdateProductById(int id, [FromBody] ProductRequestModel productRequestModel)
        {
            _productService.Repo.UpdateProductById(id, productRequestModel);
            var product = _productService.Repo.GetProductById(id);
            if (product == null)
            {
                return new ProductResponseModel();
            }
            return new ProductResponseModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }
        [HttpDelete("{id}")]
        public void DeleteProductById(int id)
        {
            // TODO: might want to handle the case where the product is not found
            _productService.Repo.DeleteProduct(id);
        }
    }
}
