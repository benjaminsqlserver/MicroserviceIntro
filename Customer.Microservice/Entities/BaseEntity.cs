using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Microservice.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
    }
}