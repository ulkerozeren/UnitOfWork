using System.Collections.Generic;

namespace WebApplication8
{
    public interface IRepository<T> where T: class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T model);
    }
}
