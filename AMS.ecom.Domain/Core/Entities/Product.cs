using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Entities
{
    public class Product
    {
        public Product() { }

        public Product(Guid id, string description, decimal price, Guid colorid, Guid categoryid, bool isactive)
        {
            ID = id;
            Description = description;
            Price = price;
            ColorId = colorid;
            CategoryID = categoryid;


        }




        public Guid ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Guid ColorId { get; set; }

        public Guid CategoryID { get; set; }

        public bool IsActive { get; set; }



    }
}
