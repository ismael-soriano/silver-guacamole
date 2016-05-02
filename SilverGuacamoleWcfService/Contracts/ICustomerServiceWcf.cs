using Domain;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SilverGuacamoleWcfService.Contracts
{
    [ServiceContract]
    public interface ICustomerServiceWcf
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AddCustomer", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Customer Add(Customer customer);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "UpdateCustomer?id={id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        Customer Update(int id, Customer customer);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "DeleteCustomer?id={id}", ResponseFormat = WebMessageFormat.Json)]
        Customer Delete(int id);

        [OperationContract]
        [WebGet(UriTemplate = "Customer?id={id}", ResponseFormat = WebMessageFormat.Json)]
        Customer Get(int id);

        [OperationContract]
        [WebGet(UriTemplate = "Customers", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Customer> GetAll();
    }
}
