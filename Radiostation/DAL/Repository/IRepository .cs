using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    interface IRepository<T>
    {
        T GetById(int id);
        void Create(T entity);
        void Remove(T entity);
        void Update(T entity);
        IQueryable<T> GetAll();


    }
}
