using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Domain;

namespace SilverGuacamoleWcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CustomerService : ICustomerService
    {
        readonly ICustomerService _customerService;
        public CustomerService()
        {
            _customerService = new CustomerService();
        }

        public Customer Add(Customer customer)
        {
            return _customerService.Add(customer);
        }

        public Customer Update(int id, Customer customer)
        {
            return _customerService.Update(id, customer);
        }

        public Customer Delete(int id)
        {
            return _customerService.Delete(id);
        }

        public Customer Get(int id)
        {
            return _customerService.Get(id);
        }

        public Customer GetAll()
        {
            return _customerService.GetAll();
        }

        public Customer GetAll(string name)
        {
            return _customerService.GetAll(name);
        }
    }
}
