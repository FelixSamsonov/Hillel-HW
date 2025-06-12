using Microsoft.AspNetCore.JsonPatch;

namespace InternetShop.WebApi.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity?> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<TEntity?> PatchAsync(int id, JsonPatchDocument<TEntity> patchDoc);
    }

}
