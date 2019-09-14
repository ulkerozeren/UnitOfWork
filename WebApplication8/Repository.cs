using System.Collections.Generic;
using System.Linq;

namespace WebApplication8
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly XContext _context;
        public Repository(XContext context)
        {
            _context = context;
        }
        public void Add(T model)
        {
            _context.Set<T>().Add(model);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
