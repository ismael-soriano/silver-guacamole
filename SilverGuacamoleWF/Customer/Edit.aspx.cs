using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;

namespace SilverGuacamoleWF.Customer
{
    public partial class Edit : System.Web.UI.Page
    {
        const string Customer_ID = "ID";
        public ICustomerService _customerService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Request.QueryString[Customer_ID]);
            if (0 != id)
            {
                var customer = _customerService.Get(id);
                if (null != customer)
                {
                    NameInput.Text = customer.Name;
                    PhoneInput.Text = customer.Phone;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Request.QueryString[Customer_ID]);
            if (0 != id)
            {
                _customerService.Update(id, new Domain.Customer() { Name = NameInput.Text, Phone = PhoneInput.Text });

            }
        }

        public override void Dispose()
        {
            _customerService.Dispose();
            base.Dispose();
        }

    }
}