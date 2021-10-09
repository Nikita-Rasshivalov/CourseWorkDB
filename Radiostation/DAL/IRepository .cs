using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IRepository<T>:IDisposable,IEnumerable<T>
    {
        IEnumerable<T> GetBookList();
        T GetBook(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
