using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
