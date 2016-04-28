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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        [WebInvoke(Method = "Post", ResponseFormat = WebMessageFormat.Json)]
        Customer Add(Customer customer);

        [OperationContract]
        [WebInvoke(Method = "Post", ResponseFormat = WebMessageFormat.Json)]
        Customer Update(int id, Customer customer);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteCustomer/{id}", ResponseFormat = WebMessageFormat.Json)]
        Customer Delete(int id);

        [OperationContract]
        [WebGet(UriTemplate = "Customer/{id}", ResponseFormat = WebMessageFormat.Json)]
        Customer Get(int id);

        [OperationContract]
        [WebGet(UriTemplate = "Customer/", ResponseFormat = WebMessageFormat.Json)]
        Customer GetAll();

        [OperationContract]
        [WebGet(UriTemplate = "Customer/{name}", ResponseFormat = WebMessageFormat.Json)]
        Customer GetAll(string name);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
