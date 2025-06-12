using InternetShop.WebApi.Data.Context;
using InternetShop.WebApi.Data.Entities;
using InternetShop.WebApi.Data.Repository;
using InternetShop.WebApi.Servise.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.WebApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _producRepository;
        public ProductService(IRepository<Product> producRepository)
        {
            _producRepository = producRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync()
        {
            return await _producRepository.GetAllAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _producRepository.GetByIdAsync(id) ?? throw new ArgumentException("Product doesn't exist");
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            await _producRepository.AddAsync(product);
            return product;
        }

        public async Task<Product?> UpdateProductAsync(int id, Product product)
        {
            var existing = await _producRepository.GetByIdAsync(id);
            if (existing is null) return null;

            await _producRepository.UpdateAsync(product);
            return existing;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var entity = await _producRepository.GetByIdAsync(id);
            if (entity is null) return false;
            return true;
        }
        public async Task<Product?> PatchProductAsync(int id, JsonPatchDocument<Product> patchDoc)
        {
            return await _producRepository.PatchAsync(id, patchDoc);
        }
    }
}
