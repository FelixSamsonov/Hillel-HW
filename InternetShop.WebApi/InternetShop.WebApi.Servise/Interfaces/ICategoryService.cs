using InternetShop.WebApi.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace InternetShop.WebApi.Servise.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();  
        Task<Category?> GetCategoryByIdAsync(int id);      
        Task<Category> CreateCategoryAsync(Category category);  
        Task<Category?> UpdateCategoryAsync(int id, Category category);  
        Task<bool> DeleteCategoryAsync(int id);              
        Task<Category?> PatchCategoryAsync(int id, JsonPatchDocument<Category> patchDoc); 
    }
}
