namespace Sayda.Core.UnitOfWork
{
	public interface IRepository { }
	public interface IRepository<T> : IRepository where T : class { }

}
