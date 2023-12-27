using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SmartEducation.DataAccess.Repositories
{

	public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		private readonly ApplicationDbContext _context;
		private readonly DbSet<TEntity> _dbSet;

		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;
			_dbSet = context.Set<TEntity>();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _dbSet.ToList();
		}

		public IEnumerable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> condition)
		{
			return _dbSet.Where(condition).ToList();
		}

		public TEntity GetById(int id)
		{
			return _dbSet.Find(id);
		}

		public void Add(TEntity entity)
		{
			_dbSet.Add(entity);
		}

		public void Update(TEntity entity)
		{
			_dbSet.Attach(entity);
			_context.Entry(entity).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			TEntity entityToDelete = _dbSet.Find(id);
			if (entityToDelete != null)
				_dbSet.Remove(entityToDelete);
		}

		public void Save()
		{
			_context.SaveChanges();
		}
	}

}
