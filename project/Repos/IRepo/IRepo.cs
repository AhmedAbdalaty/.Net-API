using System.Collections.Generic;

namespace Repos.IRepo
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        T GetByID(int id);
        void InsertData(T item);
        T UpdateData(T item);
        void RemoveItem(int id);
        void SaveChanges();
    }
}
