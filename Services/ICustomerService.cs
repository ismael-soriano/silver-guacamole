using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Services
{
    public interface ICustomerService : IDisposable
    {
        Customer Add(Customer customer);
        void Update(int id, Customer customer);
        void Delete(int id);
        Customer Get(int id);
        IEnumerable<Customer> GetAll(string name);
    }
}
