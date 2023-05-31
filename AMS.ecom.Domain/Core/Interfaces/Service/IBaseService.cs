using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Interfaces.Service
{
    public interface IBaseService<T> where T : class
    {
        Task Add();

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(Guid id);

        void Update(T entity);

       // void Delete(Guid id);
    }
}
