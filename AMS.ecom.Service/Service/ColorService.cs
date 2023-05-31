using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Service.Service
{
    public class ColorService: IBaseService<Color>
    {
        private readonly IRepository<Color> _repository;
        public ColorService(IRepository<Color> repository)
        {
            _repository = repository;
        }
        public async Task Add(Color entity)
        {
            await _repository.Add(entity);
        }

        public Task<IEnumerable<Product>> GetAll()
        {

        }
        public Task<Product> GetById(Guid id)
        {

        }
        public void Update(Product entity)
        {

        }

        public void Delete(Product entity)
        {

        }





    }
}
