using System;
using System.Collections.Generic;

namespace DAL
{
    interface IRepository<T>
    {
        T GetById(int id);
        void Create(T entity);
        void Remove(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();


    }
}
