using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace B2B.SharedKernel
{
    public class GenericRepository<TEntity> where TEntity: class, IEntity
    {
        internal DbContext _context;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public OperationResult Add(TEntity entity)
        {
            var opr = new OperationResult();

            _dbSet.Add(entity);

            try
            {
                _context.SaveChanges();

                return opr;
            }
            catch (Exception e)
            {
                _dbSet.Remove(entity);
                opr.Success = false;
                opr.MessageList.Add("Ekleme basarisiz");

                return opr;
            }

        }

        public OperationResult Update(TEntity entity)
        {

            var opr = new OperationResult();

            _context.Set<TEntity>().AddOrUpdate(entity);

            try
            {
                _context.SaveChanges();

                return opr;
            }
            catch (Exception e)
            {
                _dbSet.Remove(entity);
                opr.Success = false;
                opr.MessageList.Add("Update basarisiz");

                return opr;
            }
        }

        public OperationResult Remove(int Id)
        {
            var opr = new OperationResult();

            var entity = _dbSet.FirstOrDefault(c => c.Id == Id);

            try
            {
                _context.Entry(entity).State = EntityState.Deleted;

                _context.SaveChanges();

                return opr;
            }
            catch
            {
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                };
                opr.Success = false;
                opr.MessageList.Add("Silme basarisiz");

                return opr;
            }

        }

        public TEntity FindByKey(int id)
        {
            return _dbSet.AsNoTracking().SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<TEntity> AllInclude
        (Expression<Func<TEntity, bool>> includeProperties)
        {
            return _dbSet.Where(includeProperties).ToList();
            //return GetAllIncluding(includeProperties).ToList();
        }

        private IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
