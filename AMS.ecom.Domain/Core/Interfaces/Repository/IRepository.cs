using AMS.ecom.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {

        Task Add(T entity);

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(Guid id);

        void Update(T entity);

       // void Delete(Guid id);
        Task Add(Product entity);
    }
}
