using System.Collections.Generic;

namespace _26Mar_BookStore.Controllers
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        bool Add(T item);
        bool Remove(T item);
        bool Edit(T item);
    }
}