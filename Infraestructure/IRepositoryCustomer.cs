using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Infraestructure
{
    interface IRepositoryCustomer:IUnitOfWork
    {
        IDbSet<Customer> Customer { get; set; }
    }
}
