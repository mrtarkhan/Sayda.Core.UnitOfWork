using System.Linq;

namespace Sayda.Core.UnitOfWork
{
	public abstract class GenericRepository<T> : IRepository<T> where T : class
	{

		protected IQueryable<T> _entities;
		protected ISession _session;

		public GenericRepository (IUnitOfWork unitOfWork)
		{
			unitOfWork.Register(this);
			_entities = unitOfWork.GetCollection<T>();
			_session = unitOfWork.GetSession();
		}



	}

}
