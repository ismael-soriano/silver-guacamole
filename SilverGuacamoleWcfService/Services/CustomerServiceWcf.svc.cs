using Domain;
using Services;
using SilverGuacamoleWcfService.Contracts;
using System;
using System.Collections.Generic;

namespace SilverGuacamoleWcfService.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CustomerServiceWcf : ICustomerServiceWcf
    {
        
        readonly ICustomerService _customerService;
        public CustomerServiceWcf(ICustomerService customerService)
        {
            Check.ArgumentIsNull(customerService, "customerService");
            _customerService = customerService;
        }

        public Customer Add(Customer customer)
        {
            return _customerService.Add(customer);
        }

        public Customer Update(int id, Customer customer)
        {
            _customerService.Update(id, customer);
            return customer;
        }

        public Customer Delete(int id)
        {
            var customer = _customerService.Get(id);
            _customerService.Delete(id);
            return customer;
        }

        public Customer Get(int id)
        {
            return _customerService.Get(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerService.GetAll();
        }
    }
}
