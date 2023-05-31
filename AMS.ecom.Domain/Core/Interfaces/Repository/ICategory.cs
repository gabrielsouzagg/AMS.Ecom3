using AMS.ecom.Domain.Core.Entities;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Interfaces.Repository
{
    public interface ICategoryId : IRepository<categoryID>
    {
        Task Add();

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(Guid id);

        void Update();

        //void Delete();
    }
}
