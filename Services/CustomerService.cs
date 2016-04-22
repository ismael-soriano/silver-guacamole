using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;

namespace Services
{
    public class CustomerService : ServiceBase, ICustomerService
    {
        readonly IDbContext _context;
        public CustomerService(IDbContext context)
        {
            if (null == context)
            {
                throw new ArgumentNullException("context");
            }
            _context = context;
        }
        public void Add()
        {
            _context.Add();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
