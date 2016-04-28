using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;

namespace SilverGuacamoleWF
{
    public partial class _Default : Page
    {
        public ICustomerService customerService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var test = customerService.Get(1);
        }
    }
}