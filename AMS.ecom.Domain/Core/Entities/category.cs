using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Entities
{
    public class categoryID
    {

        public categoryID() { }

        public categoryID(Guid id, string description) 
        { 
         ID = id;
         Description = description;
        }



        public Guid ID { get; set; }
        public string Description { get; set; }
    }
}
