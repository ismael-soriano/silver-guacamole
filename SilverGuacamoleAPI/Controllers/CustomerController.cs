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

            //return new string[] { "value1", "value2" };
        }

        // GET api/customer/5
        public string Get(int id)
        {
            return _service.Get(id).ToString();
            //return "value";
        }

        // POST api/customer
        public void Post([FromBody]string value)
        {
        }

        // PUT api/customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/customer/5
        public void Delete(int id)
        {
        }
    }
}
