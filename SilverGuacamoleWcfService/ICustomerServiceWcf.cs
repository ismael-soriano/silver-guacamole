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
    [ServiceContract]
    public interface ICustomerServiceWcf
    {
        [OperationContract]
        [WebInvoke]
        //[WebInvoke(Method = "Post", ResponseFormat = WebMessageFormat.Json)]
        Customer Add(Customer customer);

        /*[OperationContract]
        [WebInvoke(UriTemplate = "UpdateCustomer?id={id}&customer={customer}", Method = "Post", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Customer Update(int id, Customer customer);*/

        [OperationContract]
        [WebInvoke]
        //[WebInvoke(UriTemplate = "DeleteCustomer/{id}", ResponseFormat = WebMessageFormat.Json)]
        Customer Delete(int id);

        [OperationContract]
        [WebGet]
        //[WebGet(UriTemplate = "Customer/{id}", ResponseFormat = WebMessageFormat.Json)]
        Customer Get(int id);

        [OperationContract]
        [WebGet]
        //[WebGet(UriTemplate = "Customer/", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Customer> GetAll();
    }
}
