using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        private readonly RepositorieContext _context;

        public RepositoryBase()
        {
            _context = new RepositorieContext();
        }
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

    }
}
