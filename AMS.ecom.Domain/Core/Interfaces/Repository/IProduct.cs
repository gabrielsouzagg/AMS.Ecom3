using AMS.ecom.Domain.Core.Entities;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Interfaces.Repository
{
    public interface IProduct : IRepository<Product>
    {
        Task Add(T entity);

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(Guid id);

        void Update(Guid id);

       // void Delete(Guid id);

    }
}
