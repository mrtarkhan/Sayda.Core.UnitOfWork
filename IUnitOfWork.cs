using System;
using System.Linq;

namespace Sayda.Core.UnitOfWork
{
	public interface IUnitOfWork
	{
		Guid Id { get; }
		void Register (IRepository repository);
		IQueryable<T> GetCollection<T> () where T : class;
		ISession GetSession ();
		void Commit ();
	}
}
