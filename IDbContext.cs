using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sayda.Core.UnitOfWork
{
	public interface IDbContext
	{
		void SaveChanges ();
		Task SaveChangesAsync (CancellationToken cancellationToken);
		IQueryable<T> GetCollection<T> () where T : class;
		ISession GetSession ();

	}

}
