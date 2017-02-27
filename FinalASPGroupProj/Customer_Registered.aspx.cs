//created by Mike Rabatich Jan 2017
//redirect page for when customers register themselves

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalASPGroupProj
{
    public partial class Customer_Registered : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((Application["CustomerID"]));
            txtBoxID.Text = (Application["CustomerID"]).ToString();
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