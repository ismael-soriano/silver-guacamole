using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;

namespace SilverGuacamoleWF.Customer
{
    public partial class Index : System.Web.UI.Page
    {
        public ICustomerService _customerService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.GridView1.DataSource = _customerService.GetAll().ToList();
                GridView1.DataBind();
            }
        }

        public override void Dispose()
        {
            _customerService.Dispose();
            base.Dispose();
        }
    }
}