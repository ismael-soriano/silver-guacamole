using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SilverGuacamoleAPI.Controllers
{
    [Authorize]
    public class CustomerController : ApiController
    {
        readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            if (null == service)
            {
                throw new ArgumentNullException("service");
            }

            _service = service;
        }

        // GET api/customer
        public IEnumerable<Customer> Get()
        {
            return _service.GetAll();
        }

        // GET api/customer/5
        public Customer Get(int id)
        {
            return _service.Get(id);
        }

        // POST api/customer
        public void Post([FromBody]Customer customer)
        {
            _service.Add(customer);
        }

        // PUT api/customer/5
        public void Put(int id, [FromBody]Customer customer)
        {
            _service.Update(id, customer);
        }

        // DELETE api/customer/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
