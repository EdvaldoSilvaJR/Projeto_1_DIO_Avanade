using System.Collections.Generic;

namespace myList.interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T retornaPorId(int id);

         void insert(T entidade);
         void delete(int id);
         void update(int id, T entidade);
         int nextId();
    }
}