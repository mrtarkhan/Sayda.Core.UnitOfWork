using System;

namespace Sayda.Core.UnitOfWork
{
	public interface IUnitOfWork
	{
		Guid Id { get; }
		void Register (IRepository repository);
		ISession GetSession ();
		void Commit ();
	}
}
