using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        readonly ICustomerService _customer;
        public CustomerService(ICustomerService customer)
        {
            if (null == customer)
            {
                throw new ArgumentNullException("The field customer can not be a \"null\"");
            }
            _customer = customer;
        }
        public void Add()
        {
            _customer.Add();
        }
     
    }
}
