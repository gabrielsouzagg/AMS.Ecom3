using AMS.ecom.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext
        (DbcContextOptions<DataContext> options)
        : base(options) { }
        DbSet<Product> Product { get; set; }
    }
}
