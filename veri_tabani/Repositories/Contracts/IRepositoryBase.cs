using Entities.entities;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        public void Create(T entity);
        public IEnumerable<T> GetAll();
    }
    public interface IProductRepository : IRepositoryBase<Product>
    {

    }
}