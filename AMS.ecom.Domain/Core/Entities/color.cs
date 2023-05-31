using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Entities
{
    public class colorID
    {

        public colorID() { }

        public colorID(Guid id, string description, bool isactive)
        {
            ID = id;
            Description = description;
        }



        public Guid ID { get; set; }

        public string Description { get; set; }

        public bool Isactive { get; set; }
    }
}
