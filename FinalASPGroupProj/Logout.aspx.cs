//created by Mike Rabatich Jan 2017
//erases logged in status set by Application and redirects

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalASPGroupProj
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //erase and redirect
            Application["CustomerID"] = null;
            Response.Redirect("Index.aspx");
        }
    }
}