using System.Linq;

namespace Sayda.Core.UnitOfWork
{
	public interface ISession
	{
		IQueryable<T> GetCollection<T> () where T : class;
	}
}
