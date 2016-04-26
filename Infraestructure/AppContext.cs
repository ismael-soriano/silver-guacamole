using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class AppContext:DbContext,IUnitOfWork,IRepositoryCustomer
    {

        public AppContext()
            : base("DefaultConnection")
        {

        }
        public IDbSet<Customer> Customers { get; set; }
    }
}
