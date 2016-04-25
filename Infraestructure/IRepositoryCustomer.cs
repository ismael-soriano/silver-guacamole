using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Infraestructure
{
    public interface IRepositoryCustomer:IUnitOfWork
    {
        IDbSet<Customer> Customers { get; set; }
    }
}
