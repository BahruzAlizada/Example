using CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
       where TEntity : class, IEntity, new()
       where TContext : DbContext, new()
    {
        #region Add
        public void Add(TEntity entity)
        {
            using var context = new TContext();
            var addEntity = context.Entry(entity);
            addEntity.State = EntityState.Added;

            context.SaveChanges();
        }

        public async Task AddAsync(TEntity entity)
        {
            using var context = new TContext();
            var addEntity = context.Entry(entity);
            addEntity.State = EntityState.Added;

            await context.SaveChangesAsync();
        }
        #endregion

        #region Delete
        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            var deleteEntity = context.Entry(entity);
            deleteEntity.State = EntityState.Deleted;

            context.SaveChanges();
        }
        #endregion

        #region Get
        public TEntity Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new TContext();
            return filter == null
                ? context.Set<TEntity>().FirstOrDefault()
                : context.Set<TEntity>().FirstOrDefault(filter);
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetAll
        public List<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new TContext();
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new TContext();
            return filter == null
                ? await context.Set<TEntity>().ToListAsync()
                : await context.Set<TEntity>().Where(filter).ToListAsync();
        }
        #endregion

        #region Update
        public void Update(TEntity entity)
        {
            using var context = new TContext();
            var updateEntity = context.Entry(entity);
            updateEntity.State = EntityState.Modified;

            context.SaveChanges();
        }

        public async void UpdateAsync(TEntity entity)
        {
            using var context = new TContext();
            var updateEntity = context.Entry(entity);
            updateEntity.State = EntityState.Modified;

            await context.SaveChangesAsync();
        }
        #endregion
    }
}
