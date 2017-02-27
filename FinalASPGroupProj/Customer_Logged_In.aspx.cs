//created by Mike Rabatich Jan 2017
//redirect page for when customer is logged in

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalASPGroupProj
{
    public partial class Customer_Logged_In : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer_Purchase_History.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer_Update.aspx");
        }
    }
}