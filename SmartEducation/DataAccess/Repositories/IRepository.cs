using System.Linq.Expressions;

namespace SmartEducation.DataAccess.Repositories
{
	public interface IGenericRepository<TEntity> where TEntity : class
	{
		IEnumerable<TEntity> GetAll();
		IEnumerable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> condition);
		TEntity GetById(int id);
		void Add(TEntity entity);
		void Update(TEntity entity);
		void Delete(int id);
		void Save();
	}

}
