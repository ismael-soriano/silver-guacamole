using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;
using Domain;

namespace Services
{
    public class CustomerService : ServiceBase, ICustomerService
    {
        readonly IRepositoryCustomer _repository;
        public CustomerService(IRepositoryCustomer repository)
            : base(repository)
        {
            if (null == repository)
            {
                throw new ArgumentNullException("repository");
            }
            _repository = repository;
        }


        public Customer Add(Customer customer)
        {
            var customerNew = _repository.Customers.Add(customer);
            SaveChanges();
            return customerNew;
        }

        public void Update(int id, Customer customer)
        {
            var customerOld = GetCustomer(id);
            CheckNullCustomer(customerOld);
            UpdateCustomer(customer, customerOld);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = GetCustomer(id);
            CheckNullCustomer(customer);
        }

        public Customer Get(int id)
        {
            return GetCustomer(id);
        }

        public IEnumerable<Customer> GetAll(string name)
        {
            return _repository.Customers.Where(c => c.Name.Contains(name) || name == null);
        }

        void UpdateCustomer(Customer customer, Customer customerOld)
        {
            customerOld.Name = customer.Name;
            customerOld.Phone = customer.Phone;
        }

        Customer GetCustomer(int id)
        {
            return _repository.Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        void CheckNullCustomer(Customer customer)
        {
            if(null == customer)
                throw new NullReferenceException("The customer doesn't exist.");
        }

    }
}
