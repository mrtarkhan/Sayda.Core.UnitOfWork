using System;
using System.Collections.Generic;

namespace Sayda.Core.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{

		IDbContext _context;
		private Dictionary<string, IRepository> _repositories;
		public event EventHandler OnCommit;
		public event EventHandler OnError;
		private Guid _id;

		public UnitOfWork (IDbContext context)
		{
			_context = context;
			_repositories = new Dictionary<string, IRepository>();
			_id = Guid.NewGuid();
		}


		public Guid Id => _id;
		public void Register (IRepository repository) => _repositories.TryAdd(repository.GetType().ToString(), repository);
		public ISession GetSession () => _context.GetSession();


		public void Commit ()
		{
			try
			{
				//add strategies
				_context.SaveChanges();
			}
			catch (Exception)
			{
				//add failure strategies
				throw;
			}
		}


		//public IQueryable<T> GetCollection<T> () where T : class
		//{
		//	return _context.GetSession().GetCollection<T>();
		//}

	}
}
