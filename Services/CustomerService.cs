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
        const string CUSTOMER_ERR_MSG = "The customer doesn't exist.";
        const string REPOSITORY_ERR_MSG = "repository";
        readonly IRepositoryCustomer _repository;
        public CustomerService(IRepositoryCustomer repository)
            : base(repository)
        {
            Check.ArgumentIsNull(repository, REPOSITORY_ERR_MSG);
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
            Check.ElementIsNull(customer, CUSTOMER_ERR_MSG);
            UpdateCustomer(customer, customerOld);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = GetCustomer(id);
            Check.ElementIsNull(customer, CUSTOMER_ERR_MSG);
        }

        public Customer Get(int id)
        {
            return GetCustomer(id);
        }

        public IEnumerable<Customer> GetAll(string name)
        {
            return _repository.Customers.Where(c => c.Name.Contains(name) || name == null);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _repository.Customers;
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
    }
}
