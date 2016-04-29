using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Domain;
using Services;

namespace SilverGuacamoleWcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CustomerServiceWcf : ICustomerServiceWcf
    {
        readonly ICustomerService _customerService;
        public CustomerServiceWcf()
        {
            _customerService = new CustomerService();
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
