//created by Mike Rabatich Jan 2017
//registration page for customers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalASPGroupProj.AppCode;


namespace FinalASPGroupProj
{
    public partial class Customer_Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegCust_OnClick(object sender, EventArgs e)
        {
            //grab entered values from the textboxes
            Customer cust = new Customer();
      
            cust.CustFirstName = txtBoxFirstName.Text.ToString();
            cust.CustLastName = txtBoxLastName.Text.ToString();
            cust.CustPassword = txtBoxPassword.Text.ToString();
            cust.CustAddress = txtBoxAddress.Text.ToString();
            cust.CustCity = txtBoxCity.Text.ToString();
            cust.CustProv = txtBoxProv.Text.ToString();
            cust.CustPostal = txtBoxPostal.Text.ToString();
            cust.Custcountry = txtBoxCountry.Text.ToString();
            cust.CustHomePhone = txtBoxHomePhone.Text.ToString();
            cust.CustBusPhone = txtBoxBusPhone.Text.ToString();
            cust.CustEmail = txtBoxCustEmail.Text.ToString();
            cust.CustAbout = txtBoxCustAbout.Text.ToString();
            //if the data can't be entered do nothing
            if(CustomerDB.Registercustomer(cust) == false)
            {

            
            }
            //otherwise set the customer as logged in and redirect
            else
            {
                (Application["CustomerID"]) = CustomerDB.getnewCustomer();

                Response.Redirect("Customer_Registered.aspx");
            }

        }

        protected void txtBoxHomePhone_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtBoxBusPhone_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Convert.ToString(args.Value) == txtBoxPassword.Text)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}