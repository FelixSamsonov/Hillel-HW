using InternetShop.WebApi.Data.Context;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.WebApi.Data.Repository
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly InternetShopContext _db;
        public EfRepository(InternetShopContext db) => _db = db;

        public async Task<IEnumerable<TEntity>> GetAllAsync()
            => await _db.Set<TEntity>().ToListAsync();

        public async Task<TEntity?> GetByIdAsync(int id)
            => await _db.Set<TEntity>().FindAsync(id);

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _db.Set<TEntity>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity?> UpdateAsync(TEntity entity)
        {
            _db.Set<TEntity>().Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var e = await _db.Set<TEntity>().FindAsync(id);
            if (e is null) return false;
            _db.Set<TEntity>().Remove(e);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<TEntity?> PatchAsync(int id, JsonPatchDocument<TEntity> patchDoc)
        {
            var entity = await _db.Set<TEntity>().FindAsync(id);
            if (entity == null)
                return null;

            // Застосовуємо зміни до сутності
            patchDoc.ApplyTo(entity);

            await _db.SaveChangesAsync();
            return entity;
        }

    }

}
