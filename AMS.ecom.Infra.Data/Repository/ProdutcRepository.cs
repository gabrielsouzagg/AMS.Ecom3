﻿using AMS.ecom.Domain.Core.Entities;
using AMS.ecom.Domain.Core.Interfaces.Repository;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Infra.Data.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly IRepository<Product> _repository;
        public ProductService(IRepository<Product> respository)
        {
            _repository = respository;
        }
        public async Task Add(Product entity)
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
