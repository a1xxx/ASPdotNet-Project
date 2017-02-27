//created by Mike Rabatich Jan 2017

//rediret page for when the customers are updated

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalASPGroupProj
{
    public partial class Customer_Updated : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Clic(object sender, EventArgs e)
        {
            Response.Redirect("Customer_Purchase_History.aspx");
        }

        protected void Button2_Clic(object sender, EventArgs e)
        {
            Response.Redirect("Customer_Update.aspx");
        }
    }
}