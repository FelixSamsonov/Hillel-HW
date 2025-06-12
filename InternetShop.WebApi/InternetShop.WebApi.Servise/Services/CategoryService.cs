using InternetShop.WebApi.Data.Entities;
using InternetShop.WebApi.Data.Repository;
using InternetShop.WebApi.Servise.Interfaces;
using Microsoft.AspNetCore.JsonPatch;

namespace InternetShop.WebApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task<Category> CreateCategoryAsync(Category category)
        {
            return await _categoryRepository.AddAsync(category);
        }

        public async Task<Category?> UpdateCategoryAsync(int id, Category category)
        {
            var existingCategory = await _categoryRepository.GetByIdAsync(id);
            if (existingCategory is null) return null;


            existingCategory.Name = category.Name; 
            existingCategory.Description = category.Description;

            await _categoryRepository.UpdateAsync(existingCategory);
            return existingCategory;
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            return await _categoryRepository.DeleteAsync(id);
        }

        public async Task<Category?> PatchCategoryAsync(int id, JsonPatchDocument<Category> patchDoc)
        {
            return await _categoryRepository.PatchAsync(id, patchDoc);
        }
    }
}
