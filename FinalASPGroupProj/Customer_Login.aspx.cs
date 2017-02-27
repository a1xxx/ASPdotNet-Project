//created by Mike Rabatich Jan 2017
//Login page for customers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalASPGroupProj.AppCode;

namespace FinalASPGroupProj
{
    public partial class Customer_Login : System.Web.UI.Page
    {
        //instantiate userID value
        public int UserID;

        public void clicked()
        {
            
        }

        protected void clicke(object sender, EventArgs e)
        {
            
            //grab values entered into textboxes then pass for customer credential validation
            string pass2 = txtboxPass.Text.ToString();

            int ID2 = Convert.ToInt32((txtBoxID.Text.ToString()));

            if (CustomerLoginCheck.checkcustlogin(ID2, pass2) == true)
            {
                Application["CustomerID"] = ID2;
                Response.Redirect("Customer_Logged_In.aspx");
            }

        }
    }
}