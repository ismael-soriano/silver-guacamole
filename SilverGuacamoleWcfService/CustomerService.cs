using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverGuacamoleWcfService
{
    public class CustomerService :ICustomerService
    {
        public Domain.Customer Add(Domain.Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Domain.Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Domain.Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Customer> GetAll(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}