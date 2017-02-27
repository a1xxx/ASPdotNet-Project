//created by Mike Rabatich Jan 2017
//update page with validation created by Alex

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalASPGroupProj.AppCode;

namespace FinalASPGroupProj
{
    public partial class Customer_Update : System.Web.UI.Page
    {
        //instantiate blank customer
         Customer cst;
        public void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Application["CustomerID"] != null)
                {
                    //enter current values into the textboxes
                    cst = CustomerDB.getCustomer(Convert.ToInt32(Application["CustomerID"]));
                    txtBoxFirstName.Text = cst.CustFirstName;
                    txtBoxLastName.Text = cst.CustLastName;
                    txtBoxAddress.Text = cst.CustAddress;
                    txtBoxCity.Text = cst.CustCity;
                    txtBoxCountry.Text = cst.Custcountry;
                    txtBoxCustEmail.Text = cst.CustEmail;
                    txtBoxHomePhone.Text = cst.CustHomePhone;
                    txtBoxPassword.Text = cst.CustPassword;
                    txtBoxProv.Text = cst.CustProv;
                    txtBoxPostal.Text = cst.CustPostal;
                    txtBoxConfirmPass.Text = cst.CustPassword;
                    //TextBox1.Text = Application["CustID"].ToString();
                }
            }

        }
        public void update(object sender, EventArgs e)
        {

            cst = CustomerDB.getCustomer(Convert.ToInt32(Application["CustomerID"]));

            //now try to update the new values
            Customer cust1 = new Customer();
                cust1.CustFirstName = txtBoxFirstName.Text.ToString();
                cust1.CustLastName = txtBoxLastName.Text.ToString();
                cust1.CustAddress = txtBoxAddress.Text.ToString();
                cust1.CustCity = txtBoxCity.Text.ToString();
                cust1.Custcountry = txtBoxCountry.Text.ToString();
                cust1.CustEmail = txtBoxCustEmail.Text.ToString();
                cust1.CustHomePhone = txtBoxHomePhone.Text.ToString();
                cust1.CustPassword = txtBoxPassword.Text.ToString();
                cust1.CustProv = txtBoxProv.Text.ToString();
                cust1.CustPostal = txtBoxPostal.Text.ToString();
                bool update;
                update = CustomerDB.updateCustomer(cst, cust1);

            Response.Redirect("Customer_Updated.aspx");
            
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